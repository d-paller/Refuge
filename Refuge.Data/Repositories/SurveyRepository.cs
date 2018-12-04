using MongoDB.Driver;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Mapping;
using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Repositories
{
    internal class SurveyRepository : ISurveyRepository
    {
        private readonly ISurveyContext _surveyContext;

        public SurveyRepository(ISurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }

        public async Task AddSurvey(Survey survey)
        {
            var dbSurvey = new SurveyMapper().MapToDbSurvey(survey);

            await _surveyContext.Survey
                .InsertOneAsync(dbSurvey);
        }

        public async Task<IEnumerable<Survey>> GetAllSurveys()
        {
            return await _surveyContext.Survey
                .Find(_ => true)
                .ToListAsync();
        }
    }
}
