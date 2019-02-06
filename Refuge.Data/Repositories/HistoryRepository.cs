using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Repositories
{
    internal class StudentHistoryRepository : IStudentHistoryRepository
    {
        private readonly IStudentHistoryContext _studentHistoryContext;

        public StudentHistoryRepository(IStudentHistoryContext sHistContext)
        {
            _studentHistoryContext = sHistContext;
        }

        public async Task AddHistory(StudentHistory history)
        {
            await _studentHistoryContext.StudentHistory
                 .InsertOneAsync(history);
        }
    }
}
