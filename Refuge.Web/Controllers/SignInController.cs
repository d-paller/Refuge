using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Refuge.Web.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("SignIn");
        }

        public IActionResult SignIn()
        {
            ViewBag.Title = "Sign In";
            return View();
        }

        public IActionResult SignOut()
        {
            ViewBag.Title = "Sign Out";
            return View();
        }
    }
}