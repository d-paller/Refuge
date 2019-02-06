using MongoDB.Bson;
using MongoDB.Driver;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Mapping;
using Refuge.Model.Classes;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Repositories
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly IClassContext _classContext;

        public StudentRepository(IClassContext classContext)
        {
            _classContext = classContext;
        }

        public async Task CreateStudentAsync(Student student)
        {
            student.IsEnabled = true;
            await _classContext.Students
                .InsertOneAsync(student);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _classContext.Students
                .Find(x=>x.IsEnabled)
                .ToListAsync();
        }

        public Task<Student> GetStudentAsync(int studentId)
        {
            //FilterDefinition<Student> filter = Builders<Student>.Filter
            //    .Eq(x=>x.StudentId, ));

            //return await _classContext.Students
            //    .Find(filter)
            //    .FirstOrDefaultAsync();
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudentsByClassIdAsync(int classId)
        {
            //FilterDefinition<Student> filter = Builders<Student>.Filter
            //    .Eq(x => x.ClassId, classId);

            //return await _classContext.Students
            //    .Find(filter)
            //    .ToListAsync();
            throw new NotImplementedException();
        }

        public async Task LogStudentOut(string id)
        {
            FilterDefinition<Student> filter = Builders<Student>.Filter
                .Eq(x => x.StudentId, id);
            UpdateDefinition<Student> def = Builders<Student>.Update
                .Set(x => x.LoggedIn, false);

            await _classContext.Students.UpdateOneAsync(filter, def);
        }

        public async Task SentStudentInactiveAsync(string id)
        {
            FilterDefinition<Student> filter = Builders<Student>.Filter
                .Eq(x => x.StudentId, id);
            UpdateDefinition<Student> def = Builders<Student>.Update
                .Set(x => x.IsEnabled, false);

            await _classContext.Students.UpdateOneAsync(filter, def);
        }

        public async Task UpdateStudentAsync(Student s)
        {
            FilterDefinition<Student> filter = Builders<Student>.Filter
                .Eq(x => x.StudentId, s.StudentId);

            await _classContext.Students
                .ReplaceOneAsync(filter, s);
        }
    }
}
