using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MoonCalculator.Models;

namespace MoonCalculator.Controllers
{
    [Route("Moon")]
    public class MoonController : Controller {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult ScanSubmit(string raw_input) {
            //Basic error handling for bad/no input;
            if(raw_input == null || raw_input.Length < 70) {
                return Redirect("Error");
            }

            //Strip column names from input
            raw_input = raw_input.Remove(0,69);

            //Normalize spacing between input to easily break down
            while(raw_input.IndexOf("	") >= 0) {
                raw_input = raw_input.Replace("	", "  ");
            }

            //Create array based on delimited spacing
            string[] initDelimit = raw_input.Split("  ");

            //Send delimited array to results page to group by moon
            TempData["Scan"] = initDelimit;

            return RedirectToAction("moon-results");
        }

        [HttpGet("moon-results")]
        public IActionResult MoonResults() {
            Moon moons = new Moon();
            Dictionary<string, Ore> moonInfo = new Dictionary<string, Ore>();
            Ore ore = new Ore();
            string[] initDelimit = (string[]) TempData["Scan"];
            string currentMoon = "";

            if(initDelimit == null) {
                return Redirect("Error");
            }

            //Group ores/quantities to a moon, add each moon to a dictionary
            for(int i = 0; i < initDelimit.Length; i++) {
                if(initDelimit[i].Contains("Moon")) {
                    if(currentMoon.Equals("")) {
                        initDelimit[i]= initDelimit[i].TrimEnd();
                        currentMoon = initDelimit[i];
                    }
                    else {
                        //logic to handle multiple moon inputs not written yet
                        moons.moonInfo.Add(currentMoon, ore);
                        //moonInfo.Add(currentMoon, ore);
                        Console.WriteLine("does this ever get reached");
                        currentMoon = initDelimit[i];
                    }
                }
                else if(Char.IsLetter(initDelimit[i][0])) {
                    ore.oreInfo.Add(initDelimit[i], initDelimit[i+1]);
                }

                if(i+1 == initDelimit.Length) {
                    moons.moonInfo.Add(currentMoon, ore);
                    //moonInfo.Add(currentMoon, ore);
                }
            }

            //Debugging
            foreach(KeyValuePair<string, Ore> moon in moons.moonInfo) {
                Console.WriteLine(moon.Key + ":");
                foreach(KeyValuePair<string, string> ores in moon.Value.oreInfo) {
                    Console.WriteLine(ores.Key + ", " + ores.Value);
                }
            }

            return View(moons);
        }

        [HttpGet("error")]
        public IActionResult badInput() {
            return View("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
