﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_b2256.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GradeCalc()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeCalc (object model)
        {
            return View();
        }
        

    }
}
