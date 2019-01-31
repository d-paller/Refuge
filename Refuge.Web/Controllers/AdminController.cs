using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refuge.Application.Interfaces;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Classes;
using Refuge.Model.Survey;
using Refuge.Web.Model;

namespace Refuge.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ISurveyRepository _surveyRepo;

        private readonly IClassBLL _classBll;
        private readonly IStudentBLL _studentBLL;

        public AdminController(IClassBLL classBll, ISurveyRepository surveyRepository, IStudentBLL studentBLL)
        {
            _classBll = classBll;
            _surveyRepo = surveyRepository;
            _studentBLL = studentBLL;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("Classes");
        }

        // ------------------------------------
        // ------------ Classes ---------------
        // ------------------------------------

        [HttpGet]
        public async Task<IActionResult> Classes()
        {
            ViewBag.Title = "Admin - Classes";
            var classes = await _classBll.GetAllClass();

            var vm = new AdminClassVm
            {
                Classes = classes.ToList()
            };

            return View(vm);
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

        // ------------------------------------
        // ------------ Students --------------
        // ------------------------------------
        [HttpGet]
        public async Task<IActionResult> Students()
        {
            ViewBag.Title = "Admin - Students";
            var vm = new StudentViewModel();

            var classes = await _classBll.GetAllClass();
            var students = await _studentBLL.GetAllStudentsAsync();

            vm.ListOfClasses = classes.Select(c => c.Name);
            vm.Students = students.ToList() ;

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student s)
        {
            await _studentBLL.CreateStudentAsync(s);
            return RedirectToAction("Students");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStudent(Student s)
        {
            ModelState.Clear();
            await _studentBLL.UpdateStudentAsync(s);
            return RedirectToAction("Students");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            await _studentBLL.DeleteStudentAsync(id);
        }
               
        // ------------------------------------
        // ------------ Surveys ---------------
        // ------------------------------------
        [HttpGet]
        public async Task<IActionResult> Surveys()
        {
            var model = await _surveyRepo.GetAllSurveys();
            ViewBag.Title = "Admin - Survey";

            return View("ViewSurveys", model.ToList());
        }

    }
}
