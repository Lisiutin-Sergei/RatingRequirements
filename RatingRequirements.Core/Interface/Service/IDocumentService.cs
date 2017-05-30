using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Service
{
    /// <summary>
    /// Интерфейс сервиса реестров.
    /// </summary>
    public interface IDocumentService
    {
        /// <summary>
        /// Получить список документов для показателя.
        /// </summary>
        /// <param name="indicatorId">Идентификатор показателя.</param>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <returns>Список документов для показателя.</returns>
        IEnumerable<Document> GetDocumentsByIndicator(Guid indicatorId, Guid registerId);

        /// <summary>
        /// Получить документ по идентификатору.
        /// </summary>
        /// <param name="documentId">Идентификатор документа.</param>
        /// <returns>Документ.</returns>
        Document GetDocumentById(Guid documentId);

        /// <summary>
        /// Сохранить документ.
        /// </summary>
        /// <param name="document">Документ.</param>
        /// <returns>Идентификатор сохраненного документа.</returns>
        Guid SaveDocument(Document document);

        /// <summary>
        /// Удалить документ.
        /// </summary>
        /// <param name="documentId">Идентификатор документа.</param>
        void DeleteDocument(Guid documentId);
    }
}
