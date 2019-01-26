using Microsoft.Extensions.Configuration;
using Refuge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Refuge.Data
{
    internal sealed class ConfigValues : IConfigValues
    {
        private readonly IConfiguration _configuration;

        public ConfigValues()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
        }
        // ---------------------------------------------
        // Connections (databases)
        // ---------------------------------------------
        public string GetMongoConnection()
        {
            //TODO
            return _configuration.GetConnectionString("DefaultMongoConnection");
        }

        // ---------------------------------------------
        // Connections (databases)
        // ---------------------------------------------
        public string GetRefugeDB()
        {
            return _configuration["DatabaseRefuge"];
        }


        // ---------------------------------------------
        // Collections
        // ---------------------------------------------
        public string GetClassesCollection()
        {
            return _configuration["CollectionClass"];
        }

        public string GetStudentsCollection()
        {
            return _configuration["CollectionStudent"];
        }

        public string GetSurveyCollection()
        {
            return _configuration["CollectionSurvey"];
        }
    }
}
