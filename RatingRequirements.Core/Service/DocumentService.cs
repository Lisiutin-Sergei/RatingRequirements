using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Service;
using RatingRequirements.Core.Model;
using RatingRequirements.Utilities.Common;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Service
{
    /// <summary>
    /// Сервис документов реестра.
    /// </summary>
    public class DocumentService : IDocumentService
    {
        private IConfiguration _configuration;
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public DocumentService(IConfiguration configuration, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _configuration = configuration;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Получить список документов для показателя.
        /// </summary>
        /// <param name="indicatorId">Идентификатор показателя.</param>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <returns>Список документов для показателя.</returns>
        public IEnumerable<Document> GetDocumentsByIndicator(Guid indicatorId, Guid registerId)
        {
            Argument.Require(indicatorId != Guid.Empty, "Не указан идентификатор показателя.");
            Argument.Require(registerId != Guid.Empty, "Не указан идентификатор реестра.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.DocumentRepository
                    .GetByFilter(e => e.IndicatorId == indicatorId && e.RegisterId == registerId);
            }
        }

        /// <summary>
        /// Получить список документов для реестра.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <returns>Список документов для реестра.</returns>
        public IEnumerable<Document> GetDocumentsByRegister(Guid registerId)
        {
            Argument.Require(registerId != Guid.Empty, "Не указан идентификатор реестра.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.DocumentRepository
                    .GetByFilter(e => e.RegisterId == registerId);
            }
        }
        
        /// <summary>
        /// Получить документ по идентификатору.
        /// </summary>
        /// <param name="documentId">Идентификатор документа.</param>
        /// <returns>Документ.</returns>
        public Document GetDocumentById(Guid documentId)
        {
            Argument.Require(documentId != Guid.Empty, "Не указан идентификатор документа.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.DocumentRepository.GetByID(documentId);
            }
        }

        /// <summary>
        /// Валидация сохранения документа.
        /// </summary>
        /// <param name="document">Документ.</param>
        /// <param name="unitOfWork">Контекст работы с базой.</param>
        private void ValidateSaveDocument(Document document, IUnitOfWork unitOfWork)
        {
            Argument.NotNullOrWhiteSpace(document.Name, "Не указано название документа.");
            Argument.Require(document.IndicatorId != Guid.Empty, "Не указан показатель документа.");
            Argument.Require(document.RegisterId != Guid.Empty, "Не указан реестр документа.");
            Argument.NotNullOrWhiteSpace(document.FileName, "Не указано имя файла документа.");
            Argument.NotNullOrWhiteSpace(document.Points, "Не указано количество баллов документа.");
        }

        /// <summary>
        /// Сохранить документ.
        /// </summary>
        /// <param name="document">Документ.</param>
        /// <returns>Идентификатор сохраненного документа.</returns>
        public Guid SaveDocument(Document document)
        {
            var isEdit = document.DocumentId != Guid.Empty;

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                ValidateSaveDocument(document, unitOfWork);
                if (isEdit)
                {
                    unitOfWork.DocumentRepository.Update(document);
                    return document.DocumentId;
                }
                else
                {
                    return unitOfWork.DocumentRepository.Insert(document);
                }
            }
        }

        /// <summary>
        /// Удалить документ.
        /// </summary>
        /// <param name="documentId">Идентификатор документа.</param>
        public void DeleteDocument(Guid documentId)
        {
            Argument.Require(documentId != Guid.Empty, "Не указан идентификатор документа.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                var document = unitOfWork.DocumentRepository.GetByID(documentId);
                unitOfWork.DocumentRepository.Delete(document);
            }
        }
    }
}
