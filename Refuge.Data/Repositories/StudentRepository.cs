using MongoDB.Bson;
using MongoDB.Driver;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Mapping;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await _classContext.Students
                .Find(_ => true)
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
            FilterDefinition<Student> filter = Builders<Student>.Filter
                .Eq(x => x.ClassId, classId);

            return await _classContext.Students
                .Find(filter)
                .ToListAsync();
        }

        public async Task UpdateStudentAsync(Student s)
        {
            var dbS = new StudentMapper().MapToDbStudent(s);

            FilterDefinition<Student> filter = Builders<Student>.Filter
                .Eq(x => x.StudentId, s.StudentId);

            await _classContext.Students
                .ReplaceOneAsync(filter, dbS);
        }
    }
}
