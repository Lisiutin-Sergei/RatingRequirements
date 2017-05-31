using System;

namespace RatingRequirements.Core.Model
{
    /// <summary>
    /// Показатель. Например, УМР1.
    /// </summary>
    public class Indicator
    {
        /// <summary>
        /// Идентификатор показателя.
        /// </summary>
        public Guid IndicatorId { get; set; }

        /// <summary>
        /// Тип показателя.
        /// </summary>
        public Guid IndicatorTypeId { get; set; }

        /// <summary>
        /// Название показателя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Шаблон формулы.
        /// </summary>
        public string FormulaBase { get; set; }

        /// <summary>
        /// Количество параметров формулы.
        /// </summary>
        public int ParamsCount { get; set; }
    }
}
