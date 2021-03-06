﻿using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Service
{
    /// <summary>
    /// Интерфейс сервиса типов показателей.
    /// </summary>
    public interface IIndicatorTypeService
    {
        /// <summary>
        /// Получить список типов показателей.
        /// </summary>
        /// <returns>Список типов показателей.</returns>
       IEnumerable<IndicatorType> GetAllIndicatorTypes();

        /// <summary>
        /// Получить список типов показателей для пользователя.
        /// </summary>
        /// <returns>Список типов показателей для пользователя.</returns>
        IEnumerable<IndicatorType> GetIndicatorTypesForUser(Guid userId);

        /// <summary>
        /// Получить тип показателя по идентификатору.
        /// </summary>
        /// <returns>Тип показателя.</returns>
        IndicatorType GetIndicatorTypeById(Guid indicatorTypeId);
    }
}
