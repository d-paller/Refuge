using MongoDB.Bson;
using MongoDB.Driver;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Mapping;
using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IClassContext _classContext;

        public StudentRepository(IClassContext classContext)
        {
            _classContext = classContext;
        }

        public async Task CreateStudentAsync(Student student)
        {
            var dbStudent = new StudentMapper().MapToDbStudent(student);

            await _classContext.Students
                .InsertOneAsync(dbStudent);
        }

        public async Task<IEnumerable<DbStudent>> GetAllStudentsAsync()
        {
            return await _classContext.Students
                .Find(_ => true)
                .ToListAsync();
        }

        public async Task<DbStudent> GetStudentAsync(int studentId)
        {
            FilterDefinition<DbStudent> filter = Builders<DbStudent>.Filter
                .Eq(x=>x.Id, ObjectId.Parse(studentId.ToString()));

            return await _classContext.Students
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<DbStudent>> GetStudentsByClassIdAsync(int classId)
        {
            FilterDefinition<DbStudent> filter = Builders<DbStudent>.Filter
                .Eq(x => x.ClassId, classId);

            return await _classContext.Students
                .Find(filter)
                .ToListAsync();
        }
    }
}
