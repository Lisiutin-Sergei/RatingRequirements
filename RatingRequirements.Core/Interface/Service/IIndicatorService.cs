using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Service
{
    /// <summary>
    /// Интерфейс сервиса показателей.
    /// </summary>
    public interface IIndicatorService
    {
        /// <summary>
        /// Получить список показателей.
        /// </summary>
        /// <returns>Список показателей.</returns>
       IEnumerable<Indicator> GetAllIndicators();

        /// <summary>
        /// Получить показатель по идентификатору.
        /// </summary>
        /// <returns>Показатель.</returns>
        Indicator GetIndicatorById(Guid indicatorId);
    }
}
