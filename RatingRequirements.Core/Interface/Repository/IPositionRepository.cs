using RatingRequirements.Core.Model.Domain;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Repository
{
    /// <summary>
    /// Интерфейс репозитория должностей.
    /// </summary>
    public interface IPositionRepository
    {
        /// <summary>
		/// Получить сущность по идентификатору.
		/// </summary>
		/// <param name="id">Идентификатор сущности.</param>
		/// <returns>Сущность.</returns>
		Position GetByID(Guid id);

        /// <summary>
        /// Получить список сущностей.
        /// </summary>
        /// <returns>Список сущностей.</returns>
        IEnumerable<Position> GetAll();
    }
}
