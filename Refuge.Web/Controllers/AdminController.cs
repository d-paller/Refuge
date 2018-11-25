﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Refuge.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Classes");
        }

        public IActionResult Classes()
        {
            ViewBag.Title = "Admin - Classes";

            return View();
        }

        public IActionResult Students()
        {
            ViewBag.Title = "Admin - Students";

            return View();
        }
    }
}