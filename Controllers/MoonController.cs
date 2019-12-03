using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            //Fix improper delimiting when breaking down all but the first moon
            int counter = 0;
            for(int i = 0; i < initDelimit.Length; i++) {
                if(initDelimit[i].Contains("Moon")) {
                    if(counter == 0) {
                        counter++;
                    }
                    else {
                        initDelimit[i] = initDelimit[i].Remove(0,8);
                    }   
                }
            }

            //Send delimited array to results page to group by moon
            TempData["Scan"] = initDelimit;

            return RedirectToAction("moon-results");
        }

        [HttpGet("moon-results")]
        public IActionResult MoonResults() {
            Moon moons = new Moon();
            Ore ore = new Ore();
            string[] initDelimit = (string[]) TempData["Scan"];
            string currentMoon = "";
            var tempMoon = new List<Ore>();

            if(initDelimit == null) {
                return Redirect("Error");
            }

            //Break moons and their respective ores down into categories
            for(int i = 0; i < initDelimit.Length; i++) {
                if(initDelimit[i].Length > 0) {
                    if(initDelimit[i].Contains("Moon")) {
                        if(currentMoon.Equals("")) {
                            Console.WriteLine("check");
                            initDelimit[i]= initDelimit[i].TrimEnd();
                            currentMoon = initDelimit[i];
                            moons.moonInfo.Add(currentMoon, new Ore());
                        }
                        else {
                            currentMoon = initDelimit[i];
                            moons.moonInfo.Add(currentMoon, new Ore());
                        }
                    }
                    else if(Char.IsLetter(initDelimit[i][0])) {
                        moons.moonInfo[currentMoon].oreInfo.Add(initDelimit[i], initDelimit[i+1]);
                    }
                }
                else {
                    return Redirect("Error");
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
        public IActionResult BadInput() {
            return View("Error");
        }

        [HttpGet("how-to")]
        public IActionResult HowTo() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
