using Microsoft.Extensions.Configuration;
using Npgsql;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Repository;
using RatingRequirements.Data.Repositories;
using System;
using System.Data;

namespace RatingRequirements.Data.UnitOfWork
{
    /// <summary>
    /// Единица работы (Паттерн Unit of Work).
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Имя узла конфигурации, хранящее значение строки подключения к БД.
        /// </summary>
        private const string _CONNECTION_STRING_NAME = "Data:DbContext:ConnectionString";
        private Lazy<DataContext> _dataContext;

        #region Репозитории

        /// <summary>
        /// Репозиторий нейронных сетей.
        /// </summary>
        public IUserRepository UserRepository => new UserRepository(_dataContext.Value);

        /// <summary>
        /// Репозиторий нейронных сетей.
        /// </summary>
        public IRegisterRepository RegisterRepository => new RegisterRepository(_dataContext.Value);

        /// <summary>
        /// Репозиторий типов показателей.
        /// </summary>
        public IIndicatorTypeRepository IndicatorTypeRepository => new IndicatorTypeRepository(_dataContext.Value);

        /// <summary>
        /// Репозиторий показателей.
        /// </summary>
        public IIndicatorRepository IndicatorRepository => new IndicatorRepository(_dataContext.Value);

        /// <summary>
        /// Репозиторий показателей.
        /// </summary>
        public IDocumentRepository DocumentRepository => new DocumentRepository(_dataContext.Value);

        #endregion

        /// <summary>
        /// Конструктор единицы работы.
        /// </summary>
        /// <param name="configuration">Конфигурация запускаемого проекта. 
        /// Должен быть заполнен узел для строки подключения к базе данных (<see cref="_CONNECTION_STRING_NAME"/>).</param>
        public UnitOfWork(IConfiguration configuration)
        {
            _dataContext = new Lazy<DataContext>(() => _CreateDataContext(configuration), true);
        }

        /// <summary>
        /// Установка соединения с базой данных.
        /// </summary>
        /// <param name="configuration">Конфигурация запускаемого проекта.</param>
        /// <returns>Контекст данных.</returns>
        private DataContext _CreateDataContext(IConfiguration configuration)
        {
            string connectionString = configuration.GetValue<string>(_CONNECTION_STRING_NAME);
            IDbConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            return new DataContext(connection, null);
        }

        /// <summary>
        /// Открыть транзакцию.
        /// </summary>
        public void BeginTransaction()
        {
            _dataContext.Value.Transaction = _dataContext.Value.Connection.BeginTransaction();
        }

        /// <summary>
        /// Подтвердить транзакцию, если она открыта.
        /// </summary>
        public void CommitTransaction()
        {
            if (_dataContext.Value.Transaction != null)
            {
                _dataContext.Value.Transaction.Commit();
                _dataContext.Value.Transaction.Dispose();
                _dataContext.Value.Transaction = null;
            }
        }

        /// <summary>
        /// Откатить транзакцию, если она открыта.
        /// </summary>
        public void RollbackTransaction()
        {
            if (_dataContext.Value.Transaction != null)
            {
                _dataContext.Value.Transaction.Rollback();
                _dataContext.Value.Transaction.Dispose();
                _dataContext.Value.Transaction = null;
            }
        }

        /// <summary>
        /// Освободить неуправляемые ресурсы единицы работы такие, как подключение к базе данных и транзакция.
        /// Если транзакция не закрыта, она откатывается.
        /// </summary>
        public void Dispose()
        {
            if (_dataContext.IsValueCreated)
            {
                RollbackTransaction();
                if (_dataContext.Value.Connection != null)
                {
                    _dataContext.Value.Connection.Dispose();
                    _dataContext.Value.Connection = null;
                }
            }
        }
    }
}
