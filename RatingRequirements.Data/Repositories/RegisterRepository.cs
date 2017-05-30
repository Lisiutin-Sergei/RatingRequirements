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
	/// Репозиторий реестров.
	/// </summary>
	public class RegisterRepository : IRegisterRepository
    {
        private DataContext _dataContext;

        /// <summary>
        /// Конструктор репозитория реестров.
        /// </summary>
        /// <param name="dataContext">Контекст данных (подключение к базе и транзакция).</param>
        public RegisterRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Вставить новый экземпляр сущности.
        /// </summary>
        /// <param name="item">Модель нового экземпляра сущности.</param>
        /// <returns>Идентификатор нового экземпляра сущности.</returns>
        public Guid Insert(Register item)
        {
            return (Guid)_dataContext.Connection.Insert(item, _dataContext.Transaction);
        }

        /// <summary>
        /// Обновить существующий экземпляр сущности.
        /// </summary>
        /// <param name="item">Модель экземпляра сущности.</param>
        public void Update(Register item)
        {
            _dataContext.Connection.Update(item, _dataContext.Transaction);
        }

        /// <summary>
        /// Удалить существующий экземпляр сущности.
        /// </summary>
        /// <param name="item">Модель экземпляра сущности.</param>
        public void Delete(Register item)
        {
            _dataContext.Connection.Delete(item, _dataContext.Transaction);
        }

        /// <summary>
        /// Получить список всех экземпляров сущности.
        /// </summary>
        /// <returns>Список всех экземпляров сущности.</returns>
        public IEnumerable<Register> GetAll()
        {
            return _dataContext.Connection.GetAll<Register>().ToList();
        }

        /// <summary>
        /// Получить список экземпляров сущности по фильтру.
        /// </summary>
        /// <param name="filter">Фильтр.</param>
        /// <returns>Список экземпляров сущности.</returns>
        public IEnumerable<Register> GetByFilter(Func<Register, bool> filter)
        {
            var data = _dataContext.Connection.GetAll<Register>();
            if (filter != null)
            {
                data = data.Where(filter);
            }
            return data.ToList();
        }

        /// <summary>
        /// Получить экземпляр сущности по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор экземпляра сущности.</param>
        /// <returns>Найденный экземпляр сущности.</returns>
        public Register GetByID(Guid id)
        {
            return _dataContext.Connection.Get<Register>(id);
        }
    }
}
