using MongoDB.Driver;
using Refuge.Data.Interfaces;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Context
{
    internal class SurveyContext : ISurveyContext
    {
        private readonly IMongoDatabase _db;
        private readonly IConfigValues _config;

        public SurveyContext(IConfigValues config)
        {
            _config = config;
            _db = new MongoClient(_config.GetMongoConnection())
                .GetDatabase(_config.GetRefugeDB());
        }

        public IMongoCollection<DbSurvey> Survey => _db.GetCollection<DbSurvey>(_config.GetSurveyCollection());
    }
}
