using Microsoft.Extensions.DependencyInjection;
using Refuge.Application.Business;
using Refuge.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Application
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection service)
        {
            service.AddTransient<IClassBLL, ClassBLL>();
            service.AddTransient<IStudentBLL, StudentBLL>();

            return service;
        }
    }
}
