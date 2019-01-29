using MongoDB.Driver;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Interfaces.Context
{
    public interface IClassContext
    {
        IMongoCollection<Class> Classes { get; }

        IMongoCollection<Student> Students { get; }
    }
}
