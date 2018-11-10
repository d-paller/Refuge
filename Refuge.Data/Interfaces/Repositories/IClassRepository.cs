using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface IClassRepository
    {
        Task<IEnumerable<Class>> GetAllClasses();

        Task CreateClass(Class classToAdd);
    }
}
