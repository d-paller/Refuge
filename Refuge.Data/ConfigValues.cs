using Refuge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Refuge.Data
{
    internal sealed class ConfigValues : IConfigValues
    {
        // ---------------------------------------------
        // Connections (databases)
        // ---------------------------------------------
        public string GetMongoConnection()
        {
            //TODO
            return "";// ConfigurationManager.ConnectionStrings["DefaultMongoConnection"].ConnectionString;
        }

        // ---------------------------------------------
        // Connections (databases)
        // ---------------------------------------------
        public string GetRefugeDB()
        {
            return ConfigurationManager.AppSettings.Get("DatabaseRefuge");
        }


        // ---------------------------------------------
        // Collections
        // ---------------------------------------------
        public string GetClassesCollection()
        {
            return ConfigurationManager.AppSettings.Get("CollectionClass");
        }

        public string GetStudentsCollection()
        {
            return ConfigurationManager.AppSettings.Get("CollectionStudent");
        }
    }
}
