using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        /*public string Welcome(string name , int numTimes = 4)
         
        {
            return HtmlEncoder.Default.Encode($"Hello Joy {name}, NumTimes is: {numTimes}");
        }*/
        public IActionResult Welcome(string name, int numTimes = 4)
        {
            ViewData["Message"] = "Hello Sandra" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}