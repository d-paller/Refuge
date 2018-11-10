using MongoDB.Bson;
using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class ClassMapper
    {
        public DbClass MapToDbClass(Class c)
        {
            return new DbClass
            {
                ClassId = c.ClassId,
                Id = ObjectId.Parse(c.ClassId.ToString()),
                Location = c.Location,
                Name = c.Name,
                StartTime = c.StartTime,
                TeacherUserId = c.TeacherUserId
            };
        }
    }
}
