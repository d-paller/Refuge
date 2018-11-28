using MongoDB.Driver;
using Refuge.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Interfaces.Context
{
    public interface ISurveyContext
    {
        IMongoCollection<DbSurvey> Survey { get; }
    }
}
