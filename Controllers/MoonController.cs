using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MoonCalculator.Models;

namespace MoonCalculator.Controllers
{
    [Route("moon")]
    public class MoonController : Controller {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult ScanSubmit(string raw_input) {
            //Console.WriteLine(raw_input);

            
            //string currentMoon = "";

            raw_input = raw_input.Remove(0,69);

            while(raw_input.IndexOf("	") >= 0) {
                raw_input = raw_input.Replace("	", "  ");
            }

            string[] initDelimit = raw_input.Split("  ");

            TempData["Scan"] = initDelimit;

            // for(int i = 0; i < initDelimit.Length; i++) {
            //     if(initDelimit[i].Contains("Moon")) {
            //         if(currentMoon.Equals("")) {
            //             initDelimit[i]= initDelimit[i].TrimEnd();
            //             currentMoon = initDelimit[i];
            //         }
            //         else {
            //             //logic to handle multiple moon inputs not written yet
            //             moonInfo.Add(currentMoon, ore);
            //             Console.WriteLine("does this ever get reached");
            //             currentMoon = initDelimit[i];
            //         }
            //     }
            //     else if(Char.IsLetter(initDelimit[i][0])) {
            //         ore.oreInfo.Add(initDelimit[i], initDelimit[i+1]);
            //     }

            //     if(i+1 == initDelimit.Length) {
            //         moonInfo.Add(currentMoon, ore);
            //     }
            // }

            // foreach(KeyValuePair<string, Moon> moon in moonInfo) {
            //     Console.WriteLine(moon.Value + ": asdasdasdasdasdas");
            //     foreach(KeyValuePair<string, string> moonOre in moon.Value.oreInfo) {
            //         Console.WriteLine(moonOre.Key + ", " + moonOre.Value);
            //     }
            // }


            return RedirectToAction("moon-results");
        }

        [HttpGet("moon-results")]
        public IActionResult MoonResults() {

            Dictionary<string, Moon> moonInfo = new Dictionary<string, Moon>();
            Moon ore = new Moon();
            string[] initDelimit = (string[]) TempData["Scan"];
            string currentMoon = "";

            // foreach(string s in data) {
            //     Console.WriteLine(s);
            // }

            for(int i = 0; i < initDelimit.Length; i++) {
                if(initDelimit[i].Contains("Moon")) {
                    if(currentMoon.Equals("")) {
                        initDelimit[i]= initDelimit[i].TrimEnd();
                        currentMoon = initDelimit[i];
                    }
                    else {
                        //logic to handle multiple moon inputs not written yet
                        moonInfo.Add(currentMoon, ore);
                        Console.WriteLine("does this ever get reached");
                        currentMoon = initDelimit[i];
                    }
                }
                else if(Char.IsLetter(initDelimit[i][0])) {
                    ore.oreInfo.Add(initDelimit[i], initDelimit[i+1]);
                }

                if(i+1 == initDelimit.Length) {
                    moonInfo.Add(currentMoon, ore);
                }
            }

            foreach(KeyValuePair<string, Moon> moon in moonInfo) {
                Console.WriteLine(moon.Key + ":");
                foreach(KeyValuePair<string, string> ores in moon.Value.oreInfo) {
                    Console.WriteLine(ores.Key + ", " + ores.Value);
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
