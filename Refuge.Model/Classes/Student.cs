using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Model.Classes
{
    public class Student
    {
        public int StudentId { get; set; }

        public int ClassId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ParentName { get; set; }

        public int ParentPhoneNumber { get; set; }

        public string ParentEmailAddress { get; set; }

        public string Address { get; set; }

    }
}
