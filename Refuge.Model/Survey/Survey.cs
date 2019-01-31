using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Refuge.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Model.Survey
{
    public class Survey
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SurveyId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public bool OkayToContactAboutRefugeActivities { get; set; }

        public string Religion { get; set; }

        public string CountryOfOrigin { get; set; }

        public string Language { get; set; }

        public DateTime DateOfArrivalInUS { get; set; }

        public LevelOfEnglish LevelOfEnglish { get; set; }

        public RefugeServices ServicesInterestedIn { get; set; }

        public string Notes { get; set; }
    }
}
