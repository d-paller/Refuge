using MongoDB.Driver;
using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Interfaces.Context
{
    public interface ISurveyContext
    {
        IMongoCollection<Survey> Survey { get; }
    }
}
