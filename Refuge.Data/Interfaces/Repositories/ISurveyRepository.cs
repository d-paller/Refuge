using Refuge.Model.Survey;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface ISurveyRepository
    {
        Task AddSurvey(Survey survey);
    }
}
