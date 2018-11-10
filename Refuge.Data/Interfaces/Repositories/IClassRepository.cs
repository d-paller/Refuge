using Refuge.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Data.Interfaces.Repositories
{
    public interface IClassRepository
    {
        Task<IEnumerable<DbClass>> GetAllClasses();

        Task CreateClass(DbClass dbClass);
    }
}
