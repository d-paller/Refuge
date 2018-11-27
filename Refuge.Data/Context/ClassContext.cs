using MongoDB.Driver;
using Refuge.Data.Interfaces;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Context
{
    internal class ClassContext : IClassContext
    {
        private readonly IMongoDatabase _db;
        private readonly IConfigValues _config;

        public ClassContext(IConfigValues config)
        {
            _config = config;
            //_db = new MongoClient(_config.GetMongoConnection())
            //    .GetDatabase(_config.GetRefugeDB());
        }

        public IMongoCollection<DbClass> Classes => _db.GetCollection<DbClass>(_config.GetClassesCollection());

        public IMongoCollection<DbStudent> Students => _db.GetCollection<DbStudent>(_config.GetStudentsCollection());
    }
}
