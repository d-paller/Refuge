using MongoDB.Bson;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class ClassMapper
    {
        public Class MapToDbClass(Class c)
        {
            return new Class
            {
                ClassId = c.ClassId,
                Location = c.Location,
                Name = c.Name,
                StartTime = c.StartTime,
                TeacherUserId = c.TeacherUserId
            };
        }
    }
}
