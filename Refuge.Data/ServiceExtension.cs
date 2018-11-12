using Microsoft.Extensions.DependencyInjection;
using Refuge.Data.Context;
using Refuge.Data.Interfaces;
using Refuge.Data.Interfaces.Context;
using Refuge.Data.Interfaces.Repositories;
using Refuge.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refuge.Data
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDataLayer(this IServiceCollection services)
        {
            services.AddTransient<IClassRepository, ClassRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IClassContext, ClassContext>();
            services.AddSingleton<IConfigValues, ConfigValues>();

            return services;
        }
    }
}
