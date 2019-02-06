using MongoDB.Driver;
using Refuge.Data.Interfaces;
using Refuge.Data.Interfaces.Context;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Context.History
{
    internal class StudentHistoryContext : IStudentHistoryContext
    {
        private readonly IMongoDatabase _db;
        private readonly IConfigValues _config;

        public StudentHistoryContext(IConfigValues config)
        {
            _config = config;
            _db = new MongoClient(_config.GetMongoConnection())
                .GetDatabase(_config.GetRefugeDB());
        }


        public IMongoCollection<StudentHistory> StudentHistory => _db.GetCollection<StudentHistory>(_config.GetStudentHistoryCollection());

    }
}
