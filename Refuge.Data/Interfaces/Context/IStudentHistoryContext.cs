using MongoDB.Driver;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Interfaces.Context
{
    public interface IStudentHistoryContext
    {
        IMongoCollection<StudentHistory> StudentHistory { get; }
    }
}
