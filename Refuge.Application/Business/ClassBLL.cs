using Refuge.Application.Interfaces;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Model.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Refuge.Application.Business
{
    internal class ClassBLL : IClassBLL
    {
        private IClassRepository _classRepository;

        public ClassBLL(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task CreateClass(Class classToAdd)
        {
            await _classRepository.CreateClass(classToAdd);
        }

        public async Task<IEnumerable<Class>> GetAllClass()
        {
            return await _classRepository.GetAllClasses();
        }

    }
}
