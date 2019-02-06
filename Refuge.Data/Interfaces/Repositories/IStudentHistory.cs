using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface IStudentHistoryRepository
    {
        Task AddHistory(StudentHistory history);
    }
}
