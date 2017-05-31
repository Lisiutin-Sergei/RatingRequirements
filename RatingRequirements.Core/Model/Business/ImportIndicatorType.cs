using System.Collections.Generic;

namespace RatingRequirements.Core.Model.Business
{
    /// <summary>
    /// Модель представления для типа показателя.
    /// </summary>
    public class ImportIndicatorType
    {
        /// <summary>
        /// Тип показателя.
        /// </summary>
        public IndicatorType IndicatorType { get; set; }

        /// <summary>
        /// Список показателей.
        /// </summary>
        public List<ImportIndicator> Indicators { get; set; }

        /// <summary>
        /// Итоговое количество баллов.
        /// </summary>
        public double Points { get; set; }
    }
}
