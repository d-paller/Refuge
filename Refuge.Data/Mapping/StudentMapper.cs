using MongoDB.Bson;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data.Mapping
{
    internal class StudentMapper
    {
        internal Student MapToDbStudent(Student s)
        {
            return new Student
            {
                Address = s.Address,
                ClassId = s.ClassId,
                FirstName = s.FirstName,
                LastName = s.LastName,
                ParentEmailAddress = s.ParentEmailAddress,
                ParentName = s.ParentName,
                ParentPhoneNumber = s.ParentPhoneNumber,
                StudentId = s.StudentId,
                LastLoggedIn = s.LastLoggedIn,
                LoggedIn = s.LoggedIn,
                Address2 = s.Address2,
                City = s.City,
                State = s.State,
                Zip = s.Zip
            };
        }

        internal Student MapFromDbStudent(Student s)
        {
            return new Student
            {
                Address = s.Address,
                ClassId = s.ClassId,
                FirstName = s.FirstName,
                LastName = s.LastName,
                ParentEmailAddress = s.ParentEmailAddress,
                ParentName = s.ParentName,
                ParentPhoneNumber = s.ParentPhoneNumber,
                LastLoggedIn = s.LastLoggedIn,
                LoggedIn = s.LoggedIn,
                Address2 = s.Address2,
                City = s.City,
                State = s.State,
                Zip = s.Zip
                
            };
        }
    }
}
