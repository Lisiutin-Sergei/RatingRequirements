using Dommel;
using RatingRequirements.Core.Interface.Repository;
using RatingRequirements.Core.Model;
using RatingRequirements.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RatingRequirements.Data.Repositories
{
    /// <summary>
    /// Репозиторий показателей.
    /// </summary>
    public class IndicatorRepository : IIndicatorRepository
    {
        private DataContext _dataContext;

        /// <summary>
        /// Конструктор репозитория показателей.
        /// </summary>
        /// <param name="dataContext">Контекст данных (подключение к базе и транзакция).</param>
        public IndicatorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Получить список всех экземпляров сущности.
        /// </summary>
        /// <returns>Список всех экземпляров сущности.</returns>
        public IEnumerable<Indicator> GetAll()
        {
            return _dataContext.Connection.GetAll<Indicator>().ToList();
        }

        /// <summary>
        /// Получить экземпляр сущности по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор экземпляра сущности.</param>
        /// <returns>Найденный экземпляр сущности.</returns>
        public Indicator GetByID(Guid id)
        {
            return _dataContext.Connection.Get<Indicator>(id);
        }
    }
}
