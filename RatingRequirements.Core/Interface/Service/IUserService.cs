using RatingRequirements.Core.Model;
using System;
using System.Collections.Generic;

namespace RatingRequirements.Core.Interface.Service
{
    /// <summary>
    /// Интерфейс сервиса пользователей.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Загрузить список пользователей.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        List<User> LoadAllUsers();

        /// <summary>
        /// Получить список пользователей по фильтру.
        /// </summary>
        /// <param name="filter">Фильтр.</param>
        /// <returns>Список пользователей.</returns>
        List<User> LoadUsersByFilter(Func<User, bool> filter);

        /// <summary>
        /// Зарегистрировать пользователя.
        /// </summary>
        /// <param name="user">Новый пользователь.</param>
        /// <returns>Идентификатор пользователя.</returns>
        Guid InsertUser(User user);
    }
}
