using RatingRequirements.Core.Interface.Repository;
using System;

namespace RatingRequirements.Core.Interface
{
    /// <summary>
	/// Единица работы (Паттерн Unit of Work).
	/// </summary>
	public interface IUnitOfWork : IDisposable
    {
        #region Repositories

        /// <summary>
        /// Репозиторий пользователей.
        /// </summary>
        IUserRepository UserRepository { get; }

        /// <summary>
        /// Репозиторий реестров.
        /// </summary>
        IRegisterRepository RegisterRepository { get; }

        /// <summary>
        /// Репозиторий типов показателей.
        /// </summary>
        IIndicatorTypeRepository IndicatorTypeRepository { get; }

        /// <summary>
        /// Репозиторий показателей.
        /// </summary>
        IIndicatorRepository IndicatorRepository { get; }

        /// <summary>
        /// Репозиторий документов.
        /// </summary>
        IDocumentRepository DocumentRepository { get; }

        #endregion

        /// <summary>
        /// Открыть транзакцию.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Подтвердить транзакцию, если она открыта.
        /// </summary>
        void CommitTransaction();

        /// <summary>
        /// Откатить транзакцию, если она открыта.
        /// </summary>
        void RollbackTransaction();
    }
}
