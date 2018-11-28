using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Model
{
    public class DbSurvey:Survey
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
