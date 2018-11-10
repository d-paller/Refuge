using MongoDB.Bson;
using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class StudentMapper
    {
        internal DbStudent MapToDbStudent(Student s)
        {
            return new DbStudent
            {
                Address = s.Address,
                ClassId = s.ClassId,
                FirstName = s.FirstName,
                Id = ObjectId.Parse(s.ClassId.ToString()),
                LastName = s.LastName,
                ParentEmailAddress = s.ParentEmailAddress,
                ParentName = s.ParentName,
                ParentPhoneNumber = s.ParentPhoneNumber,
                StudentId = s.StudentId
            };
        }
    }
}
