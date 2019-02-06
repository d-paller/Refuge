using Refuge.Model.Classes;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAllStudentsAsync();

        Task<Student> GetStudentAsync(int studentId);

        Task CreateStudentAsync(Student student);

        Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId);

        Task UpdateStudentAsync(Student s);

        Task SentStudentInactiveAsync(string id);

        Task LogStudentOut(string id);
    }
}
