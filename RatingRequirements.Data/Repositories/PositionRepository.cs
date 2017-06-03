using Dommel;
using RatingRequirements.Core.Interface.Repository;
using RatingRequirements.Core.Model;
using RatingRequirements.Core.Model.Domain;
using RatingRequirements.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RatingRequirements.Data.Repositories
{
    /// <summary>
    /// Репозиторий должностей.
    /// </summary>
    public class PositionRepository : IPositionRepository
    {
        private DataContext _dataContext;

        /// <summary>
        /// Конструктор репозитория должностей.
        /// </summary>
        /// <param name="dataContext">Контекст данных (подключение к базе и транзакция).</param>
        public PositionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Получить список всех экземпляров сущности.
        /// </summary>
        /// <returns>Список всех экземпляров сущности.</returns>
        public IEnumerable<Position> GetAll()
        {
            return _dataContext.Connection.GetAll<Position>().ToList();
        }

        /// <summary>
        /// Получить экземпляр сущности по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор экземпляра сущности.</param>
        /// <returns>Найденный экземпляр сущности.</returns>
        public Position GetByID(Guid id)
        {
            return _dataContext.Connection.Get<Position>(id);
        }
    }
}
