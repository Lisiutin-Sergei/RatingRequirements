using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Service;
using System.Collections.Generic;
using RatingRequirements.Core.Model;
using System;
using RatingRequirements.Utilities.Common;

namespace RatingRequirements.Core.Service
{
    /// <summary>
    /// Сервис показателей.
    /// </summary>
    public class IndicatorService : IIndicatorService
    {
        private IConfiguration _configuration;
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public IndicatorService(IConfiguration configuration, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _configuration = configuration;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Получить список показателей.
        /// </summary>
        /// <returns>Список показателей.</returns>
        public IEnumerable<Indicator> GetAllIndicators()
        {
            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.IndicatorRepository.GetAll();
            }
        }

        /// <summary>
        /// Получить показатель по идентификатору.
        /// </summary>
        /// <returns>Показатель.</returns>
        public Indicator GetIndicatorById(Guid indicatorId)
        {
            Argument.Require(indicatorId != Guid.Empty, "Не указан идентификатор показателя.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.IndicatorRepository.GetByID(indicatorId);
            }
        }
    }
}
