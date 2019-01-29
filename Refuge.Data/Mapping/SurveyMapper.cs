using MongoDB.Bson;
using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class SurveyMapper
    {
        internal Survey MapToDbSurvey(Survey s)
        {
            return new Survey
            {
                Address = s.Address,
                CountryOfOrigin = s.CountryOfOrigin,
                DateOfArrivalInUS = s.DateOfArrivalInUS,
                Email = s.Email,
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
