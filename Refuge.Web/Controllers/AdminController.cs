using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refuge.Application.Interfaces;
using Refuge.Model.Classes;
using Refuge.Web.Model;

namespace Refuge.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IClassBLL _classBll;

        public AdminController(IClassBLL classBll)
        {
            _classBll = classBll;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("Classes");
        }

        [HttpGet]
        public IActionResult Classes()
        {
            ViewBag.Title = "Admin - Classes";
            var classes = testListOfClasses;  //await _classBll.GetAllClass();

            var vm = new AdminClassVm
            {
                Classes = classes.ToList()
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult Students()
        {
            ViewBag.Title = "Admin - Students";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddClass(Class classToAdd)
        {
            await _classBll.CreateClass(classToAdd);
            return RedirectToAction("Classes");
        }

        [HttpGet]
        public IActionResult EditClassPage(Class classToEdit)
        {
            ViewBag.Title = "Admin - Classes";
            return View("EditClass", classToEdit);
        }

        List<Class> testListOfClasses = new List<Class>
        {
            new Class
            {
                DayOfWeek = DayOfWeek.Tuesday,
                Location = "Welcome Center",
                Name = "Homework Help",
                StartTime = new DateTime(1,1,1,18,0,0),
                TeacherName = "John Doe",
                ClassId = 1
            },
            new Class
            {
                TeacherName = "David Paller",
                StartTime = new DateTime(1,1,1,18,30,0),
                Name = "Computer Class",
                Location = "Welcome Center",
                DayOfWeek = DayOfWeek.Monday,
                ClassId = 2
            }
        };
    }
}