using System;

namespace RatingRequirements.UI.Import
{
    /// <summary>
    /// Интерфейс для утилит импорта.
    /// </summary>
    public interface IImport
    {
        /// <summary>
        /// Импортировать реестр.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <param name="openAfterSave">Открыть ли после сохранения.</param>
        void ImportRegister(Guid registerId, bool openAfterSave = true);
    }
}
