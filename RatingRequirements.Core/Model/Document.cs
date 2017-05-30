using System;

namespace RatingRequirements.Core.Model
{
    /// <summary>
    /// Документ показателя. Строка таблицы.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Идентификатор документа.
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Покаатель.
        /// </summary>
        public Guid IndicatorId { get; set; }

        /// <summary>
        /// Название документа.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Имя файла.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Формула в текстовом представлении.
        /// </summary>
        public string Formula { get; set; }

        /// <summary>
        /// Количество баллов.
        /// </summary>
        public string Points { get; set; }

        /// <summary>
        /// Идентификатор реестра.
        /// </summary>
        public Guid RegisterId { get; set; }
    }
}
