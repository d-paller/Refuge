using Refuge.Application.Interfaces;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Application.Business
{
    internal class StudentBLL : IStudentBLL
    {
        private IStudentRepository _studentRepository;

        public StudentBLL(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        internal async Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId)
        {
            return await _studentRepository.GetStudentsByClassIdAsync(classId);
        }

        internal async Task<Student> GetStudentByIdAsync(int studentId)
        {

            return await _studentRepository.GetStudentAsync(studentId);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }

        public async Task CreateStudent(Student student)
        {
            await _studentRepository.CreateStudentAsync(student);
        }
    }
}
