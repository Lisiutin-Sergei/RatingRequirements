using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Service;
using System.Collections.Generic;
using System.Linq;
using RatingRequirements.Core.Model;
using System;

namespace RatingRequirements.Core.Service
{
    /// <summary>
    /// Сервис пользователей.
    /// </summary>
    public class UserService : IUserService
    {
        private IConfiguration _configuration;
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public UserService(IConfiguration configuration, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _configuration = configuration;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Загрузить список пользователей.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public List<User> LoadAllUsers()
        {
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.UserRepository.GetAll().ToList();
            }
        }

        /// <summary>
        /// Получить список пользователей по фильтру.
        /// </summary>
        /// <param name="filter">Фильтр.</param>
        /// <returns>Список пользователей.</returns>
        public List<User> LoadUsersByFilter(Func<User, bool> filter)
        {
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.UserRepository.GetByFilter(filter).ToList();
            }
        }

        /// <summary>
        /// Зарегистрировать пользователя.
        /// </summary>
        /// <param name="user">Новый пользователь.</param>
        /// <returns>Идентификатор пользователя.</returns>
        public Guid InsertUser(User user)
        {
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.UserRepository.Insert(user);
            }
        }
    }
}
