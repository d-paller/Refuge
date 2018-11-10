using MongoDB.Driver;
using Refuge.Data.Interfaces;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Mapping;
using Refuge.Data.Model;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Refuge.Data.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly IClassContext _classContext;

        public ClassRepository(IClassContext classContext)
        {
            _classContext = classContext;
        }

        public async Task<IEnumerable<Class>> GetAllClasses()
        {
            return await _classContext.Classes
                .Find(_ => true)
                .ToListAsync();
        }

        public async Task CreateClass(Class classToAdd)
        {
            var dbClass = new ClassMapper().MapToDbClass(classToAdd);
            await _classContext.Classes
                .InsertOneAsync(dbClass);
        }

    }
}
