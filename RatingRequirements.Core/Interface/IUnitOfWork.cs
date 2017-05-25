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
