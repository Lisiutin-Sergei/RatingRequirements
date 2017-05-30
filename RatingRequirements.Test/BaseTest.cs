using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RatingRequirements.Data;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Collections.Generic;
using System.IO;

namespace RatingRequirements.Test
{
    /// <summary>
    /// Базовый класс для интеграционных тестов.
    /// </summary>
    public class BaseTest
    {
        static BaseTest()
        {
            FluentMappingConfiguration.ConfigureMapping();
        }

        /// <summary>
        /// Получить конфигурацию.
        /// </summary>
        /// <returns></returns>
        protected static IConfigurationRoot GetConfiguration()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"]?.ConnectionString;
            if (connectionString == null)
            {
                throw new Exception("Не задана строка подключения к БД");
            }
            var config = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Data:DbContext:ConnectionString", connectionString)
            };
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddInMemoryCollection(config)
                .Build();
        }
    }
}
