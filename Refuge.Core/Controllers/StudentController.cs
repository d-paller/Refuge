using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Refuge.Application.Interfaces;
using Refuge.Model.Classes;
using Refuge.Model.Student;

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

        [HttpPost]
        public async Task AddStudent(string studentJson)
        {
            var student = JsonConvert.DeserializeObject<Student>(studentJson);
            await _studentBll.CreateStudentAsync(student);
        }

        [HttpGet]
        public async Task<ActionResult<Student>> GetStudentById(int studentId)
        {
            return new JsonResult(await _studentBll.GetStudentByIdAsync(studentId));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudentsByClassId(int classId)
        {
            return new JsonResult(await _studentBll.GetStudentsByClassIdAsync(classId));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            return new JsonResult(await _studentBll.GetAllStudentsAsync());
        }

    }
}