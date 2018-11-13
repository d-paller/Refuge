using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Refuge.Application.Interfaces;
using Refuge.Model.Classes;

namespace Refuge.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassBLL _classBll;

        public ClassController(IClassBLL classBLL)
        {
            _classBll = classBLL;
        }

        [HttpGet]
        public ActionResult<Class> GetAllClass()
        {
            var allClasses = _classBll.GetAllClass();
            return new JsonResult(allClasses);
        }

        [HttpPost]
        public void AddClass(string classToAdd)
        {
            var newClass = JsonConvert.DeserializeObject<Class>(classToAdd);

            _classBll.CreateClass(newClass);
        }
    }
}