﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathTest.API.Controllers
{
    public class MultiplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
