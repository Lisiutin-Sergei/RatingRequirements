using System;

namespace RatingRequirements.Core.Model
{
    /// <summary>
    /// Тип показателя. Например, УЧЕБНО-МЕТОДИЧЕСКАЯ РАБОТА.
    /// </summary>
    public class IndicatorType
    {
        /// <summary>
        /// Идентификатор типа показателя.
        /// </summary>
        public Guid IndicatorTypeId { get; set; }

        /// <summary>
        /// Название типа показателя.
        /// </summary>
        public string Name { get; set; }
    }
}
