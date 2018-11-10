using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<DbStudent>> GetAllStudentsAsync();

        Task<DbStudent> GetStudentAsync(int studentId);

        Task CreateStudentAsync(Student student);

        Task<IEnumerable<DbStudent>> GetStudentsByClassIdAsync(int classId);
    }
}
