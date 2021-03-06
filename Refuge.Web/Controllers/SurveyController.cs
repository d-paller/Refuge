﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Survey;

namespace Refuge.Web.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ISurveyRepository _surveyRepository;

        public SurveyController(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Survey";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSurvey(Survey s)
        {
            await _surveyRepository.AddSurvey(s);

            ViewBag.Title = "Survey";
            return View("Index");
        }
    }
}