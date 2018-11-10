using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Application.Interfaces
{
    public interface IClassBLL
    {
        Task CreateClass(Class classToAdd);

        Task<IEnumerable<Class>> GetAllClass();

    }
}
