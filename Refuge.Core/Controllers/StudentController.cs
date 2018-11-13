using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refuge.Application.Interfaces;

namespace Refuge.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBLL _studentBll;

        public StudentController(IStudentBLL studentBll)
        {
            _studentBll = studentBll;
        }

        

    }
}