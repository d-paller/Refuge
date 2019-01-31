using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Refuge.Model.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Model.Classes
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string StudentId { get; set; }

        public int ClassId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ParentName { get; set; }

        public int ParentPhoneNumber { get; set; }

        public string ParentEmailAddress { get; set; }

        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public bool LoggedIn { get; set; }

        public DateTime LastLoggedIn { get; set; }

        public bool IsEnabled { get; set; }

    }
}
