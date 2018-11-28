using MongoDB.Bson;
using Refuge.Data.Model;
using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class SurveyMapper
    {
        internal DbSurvey MapToDbSurvey(Survey s)
        {
            return new DbSurvey
            {
                Address = s.Address,
                CountryOfOrigin = s.CountryOfOrigin,
                DateOfArrivalInUS = s.DateOfArrivalInUS,
                Email = s.Email,
                Id = new ObjectId(s.SurveyId.ToString()),
                Language = s.Language,
                SurveyId = s.SurveyId,
                LevelOfEnglish = s.LevelOfEnglish,
                Name = s.Name,
                Notes = s.Notes,
                OkayToContactAboutRefugeActivities = s.OkayToContactAboutRefugeActivities,
                Phone = s.Phone,
                Religion = s.Religion,
                ServicesInterestedIn = s.ServicesInterestedIn
            };
        }
    }
}
