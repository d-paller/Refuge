using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Refuge.Web.Model
{
    public class AdminClassVm
    {
        public int NumOfClasses { get; set; }

        public List<Class> Classes { get; set; }
    }
}
