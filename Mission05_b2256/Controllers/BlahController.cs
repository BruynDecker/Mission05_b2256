using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission05_b2256.Models;

namespace Mission05_b2256.Controllers
{
    public class BlahController : Controller
    {
        //This get request shows the Index.cshtml page
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //This get request shows the grade calc page
        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }

        //this posts the grade calculation information
        [HttpPost]
        public IActionResult GradeCalc (GradeCalcModels model)
        {
            return View();
        }
        

    }
}
