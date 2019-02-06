using Refuge.Model.Classes;
using Refuge.Model.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refuge.Web.Model
{
    public class StudentViewModel
    {
        public List<Student> Students { get; set; }

        public IEnumerable<string> ListOfClasses { get; set; }

        public Student StudentToAdd { get; set; }
    }
}
