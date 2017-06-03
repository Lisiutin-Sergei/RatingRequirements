using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Service;
using System.Collections.Generic;
using RatingRequirements.Core.Model;
using System;
using RatingRequirements.Utilities.Common;
using RatingRequirements.Core.Model.Domain;
using System.Linq;

namespace RatingRequirements.Core.Service
{
    /// <summary>
    /// Сервис типов показателей.
    /// </summary>
    public class IndicatorTypeService : IIndicatorTypeService
    {
        private IConfiguration _configuration;
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public IndicatorTypeService(IConfiguration configuration, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _configuration = configuration;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Получить список типов показателей.
        /// </summary>
        /// <returns>Список типов показателей.</returns>
        public IEnumerable<IndicatorType> GetAllIndicatorTypes()
        {
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.IndicatorTypeRepository.GetAll();
            }
        }

        /// <summary>
        /// Получить список типов показателей для пользователя.
        /// </summary>
        /// <returns>Список типов показателей для пользователя.</returns>
        public IEnumerable<IndicatorType> GetIndicatorTypesForUser(Guid userId)
        {
            Argument.Require(userId != Guid.Empty, "Не указан идентификатор пользователя.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                var user = unitOfWork.UserRepository.GetByID(userId);
                var indicatorTypes = unitOfWork.IndicatorTypeRepository.GetAll();

                return user.PositionId == PositionEnum.ZK
                    ? indicatorTypes
                    : indicatorTypes.Where(e => e.IndicatorTypeId != IndicatorTypeEnum.Zvk);
            }
        }

        /// <summary>
        /// Получить тип показателя по идентификатору.
        /// </summary>
        /// <returns>Тип показателя.</returns>
        public IndicatorType GetIndicatorTypeById(Guid indicatorTypeId)
        {
            Argument.Require(indicatorTypeId != Guid.Empty, "Не указан идентификатор типа показателя.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.IndicatorTypeRepository.GetByID(indicatorTypeId);
            }
        }
    }
}
