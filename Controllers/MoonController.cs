using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            Console.WriteLine(raw_input);

            // Dictionary<string, Moon> moonInfo = new Dictionary<string, Moon>();

            //raw_input = raw_input.Remove(0,69);

            // while(raw_input.IndexOf("	") >= 0) {
            //     raw_input = raw_input.Replace("	", "  ");
            // }

            // string[] initDelimit = raw_input.Split("  ");

            return RedirectToAction("moon-results");
        }

        [HttpGet("moon-results")]
        public IActionResult MoonResults(Dictionary<string, Moon> results) {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
