﻿using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;

namespace RatingRequirements.Data.UnitOfWork
{
    /// <summary>
	/// Фабрика единиц работы.
	/// </summary>
	public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        /// <summary>
        /// Создать новую единицу работы с заданной конфигурацией.
        /// </summary>
        /// <param name="configuration">Конфигурация для единицы работы.</param>
        /// <returns>Экземпляр единицы работы.</returns>
        public IUnitOfWork Create(IConfiguration configuration)
        {
            return new UnitOfWork(configuration);
        }
    }
}
