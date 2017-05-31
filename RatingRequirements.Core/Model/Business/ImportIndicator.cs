using System.Collections.Generic;

namespace RatingRequirements.Core.Model.Business
{
    /// <summary>
    /// Модель представления для показателя.
    /// </summary>
    public class ImportIndicator
    {
        /// <summary>
        /// Показатель.
        /// </summary>
        public Indicator Indicator { get; set; }

        /// <summary>
        /// Список документов.
        /// </summary>
        public List<Document> Documents { get; set; }
    }
}
