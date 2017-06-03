using RatingRequirements.Core.Model;
using RatingRequirements.Core.Model.Business;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Service
{
    /// <summary>
    /// Интерфейс сервиса реестров.
    /// </summary>
    public interface IRegisterService
    {
        /// <summary>
        /// Получить реестр по идентификатору.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <returns>Реестр.</returns>
        Register GetRegisterById(Guid registerId);

        /// <summary>
        /// Получить список реестров для пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список реестров для пользователя.</returns>
        IEnumerable<Register> GetRegistersByUserId(Guid userId);

        /// <summary>
        /// Получить полный список документов с разбивкой по показателям и их типам.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Полный список документов с разбивкой по показателям и их типам.</returns>
        List<ImportIndicatorType> GetImportIndicatorTypes(Guid registerId, Guid userId);

        /// <summary>
        /// Сохранить реестр.
        /// </summary>
        /// <param name="register">Реестр.</param>
        /// <returns>Идентификатор сохраненного реестра.</returns>
        Guid SaveRegister(Register register);

        /// <summary>
        /// Удалить реестр.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        void DeleteRegister(Guid registerId);
    }
}
