using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Repository
{
    /// <summary>
    /// Интерфейс репозитория типов показателей.
    /// </summary>
    public interface IIndicatorTypeRepository
    {
        /// <summary>
        /// Получить список сущностей.
        /// </summary>
        /// <returns>Список сущностей.</returns>
        IEnumerable<IndicatorType> GetAll();

        /// <summary>
        /// Получить сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор сущности.</param>
        /// <returns>Сущность.</returns>
        IndicatorType GetByID(Guid id);
    }
}
