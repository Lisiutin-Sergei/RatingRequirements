using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Repository
{
    /// <summary>
    /// Интерфейс репозитория документов реестра.
    /// </summary>
    public interface IDocumentRepository
    {
        /// <summary>
        /// Получить сущность по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор сущности.</param>
        /// <returns>Сущность.</returns>
        Document GetByID(Guid id);

        /// <summary>
        /// Получить список сущностей.
        /// </summary>
        /// <returns>Список сущностей.</returns>
        IEnumerable<Document> GetAll();

        /// <summary>
        /// Получить список сущностей по фильтру.
        /// </summary>
        /// <param name="filter">Фильтр.</param>
        /// <returns>Список сущностей.</returns>
        IEnumerable<Document> GetByFilter(Func<Document, bool> filter);

        /// <summary>
        /// Создать новую сущность.
        /// </summary>
        /// <param name="entity">Сущность для сохранения.</param>
        /// <returns>Идентификатор нового экземпляра сущности.</returns>
        Guid Insert(Document entity);

        /// <summary>
        /// Обновить сущность.
        /// </summary>
        /// <param name="entity">Сущность для сохранения.</param>
        void Update(Document entity);

        /// <summary>
        /// Удалить сущность.
        /// </summary>
        /// <param name="entity">Сущность для удаления.</param>
        void Delete(Document
            entity);
    }
}
