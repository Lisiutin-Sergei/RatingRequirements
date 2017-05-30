using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Repository
{
    /// <summary>
    /// Интерфейс репозитория показателей.
    /// </summary>
    public interface IIndicatorRepository
    {
        /// <summary>
        /// Получить список сущностей.
        /// </summary>
        /// <returns>Список сущностей.</returns>
        IEnumerable<Indicator> GetAll();

        /// <summary>
        /// Получить сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор сущности.</param>
        /// <returns>Сущность.</returns>
        Indicator GetByID(Guid id);
    }
}
