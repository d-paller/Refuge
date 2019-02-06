using Refuge.Application.Interfaces;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Classes;
using Refuge.Model.Enums;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Application.Business
{
    internal class StudentBLL : IStudentBLL
    {
        private IStudentRepository _studentRepository;
        private IStudentHistoryRepository _studentHistoryRepository;

        public StudentBLL(IStudentRepository studentRepository, IStudentHistoryRepository studentHistoryRepository)
        {
            _studentRepository = studentRepository;
            _studentHistoryRepository = studentHistoryRepository;
        }

        public async Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId)
        {
            return await _studentRepository.GetStudentsByClassIdAsync(classId);
        }

        public async Task<Student> GetStudentByIdAsync(int studentId)
        {
            return await _studentRepository.GetStudentAsync(studentId);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }

        public async Task CreateStudentAsync(Student student)
        {
            var hist = new StudentHistory(HistoryEvent.Add, student.StudentId);

            await _studentRepository.CreateStudentAsync(student);
            await _studentHistoryRepository.AddHistory(hist);
        }

        public async Task UpdateStudentAsync(Student s)
        {
            var hist = new StudentHistory (HistoryEvent.Update, s.StudentId);

            await _studentRepository.UpdateStudentAsync(s);
            await _studentHistoryRepository.AddHistory(hist);
        }

        public async Task DeleteStudentAsync(string id)
        {
            var hist = new StudentHistory(HistoryEvent.Delete, id);

            await _studentRepository.SentStudentInactiveAsync(id);
            await _studentHistoryRepository.AddHistory(hist);
        }

        public async Task LogStudentOut(string id, DateTime? differentDate = null)
        {
            var hist = new StudentHistory(HistoryEvent.Logout, id);

            if (differentDate != null)
            {
                hist.TimeOfEvent = differentDate.Value;
            }

            await _studentRepository.LogStudentOut(id);
            await _studentHistoryRepository.AddHistory(hist);
        }
    }
}
