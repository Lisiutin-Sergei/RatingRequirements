﻿using Microsoft.Extensions.Configuration;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Service;
using System;
using System.Collections.Generic;
using RatingRequirements.Core.Model;
using RatingRequirements.Utilities.Common;
using RatingRequirements.Utilities.ExtensionMethods;
using System.Linq;
using RatingRequirements.Core.Model.Business;
using RatingRequirements.Core.Model.Domain;

namespace RatingRequirements.Core.Service
{
    /// <summary>
    /// Сервис реестров.
    /// </summary>
    public class RegisterService : IRegisterService
    {
        private IConfiguration _configuration;
        private IUnitOfWorkFactory _unitOfWorkFactory;

        public RegisterService(IConfiguration configuration, IUnitOfWorkFactory unitOfWorkFactory)
        {
            _configuration = configuration;
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        /// <summary>
        /// Получить список реестров для пользователя.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Список реестров для пользователя.</returns>
        public IEnumerable<Register> GetRegistersByUserId(Guid userId)
        {
            Argument.Require(userId != Guid.Empty, "Не указан идентификатор пользователя.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.RegisterRepository.GetByFilter(e => e.UserId == userId);
            }
        }

        /// <summary>
        /// Получить реестр по идентификатору.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <returns>Реестр.</returns>
        public Register GetRegisterById(Guid registerId)
        {
            Argument.Require(registerId != Guid.Empty, "Не указан идентификатор реестра.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                return unitOfWork.RegisterRepository.GetByID(registerId);
            }
        }

        /// <summary>
        /// Валидация сохранения рееста.
        /// </summary>
        /// <param name="register">Реестр.</param>
        /// <param name="unitOfWork">Контекст работы с базой.</param>
        private void ValidateSaveRegister(Register register, IUnitOfWork unitOfWork)
        {
            Argument.NotNullOrWhiteSpace(register.Name, "Не указано название реестра.");
            Argument.Require(register.RegisterDate != default(DateTime), "Не указана дата реестра.");
            Argument.Require(register.UserId != Guid.Empty, "Не указан владелец реестра");

            var foundRegister = unitOfWork.RegisterRepository
                .GetByFilter(e =>
                    e.RegisterDate.Date == register.RegisterDate.Date &&
                    e.Name.EqualsIgnoreCase(register.Name) &&
                    e.UserId == register.UserId &&
                    e.RegisterId != register.RegisterId)
                .FirstOrDefault();
            if (foundRegister != null)
            {
                throw new Exception("Найден сохраненный реестр с той же датой и тем же названием.");
            }
        }

        /// <summary>
        /// Сохранить реестр.
        /// </summary>
        /// <param name="register">Реестр.</param>
        /// <returns>Идентификатор сохраненного реестра.</returns>
        public Guid SaveRegister(Register register)
        {
            var isEdit = register.RegisterId != Guid.Empty;

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                ValidateSaveRegister(register, unitOfWork);
                if (isEdit)
                {
                    unitOfWork.RegisterRepository.Update(register);
                    return register.RegisterId;
                }
                else
                {
                    return unitOfWork.RegisterRepository.Insert(register);
                }
            }
        }

        /// <summary>
        /// Удалить реестр и его документы в транзакции.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        public void DeleteRegister(Guid registerId)
        {
            Argument.Require(registerId != Guid.Empty, "Не указан идентификатор реестра.");

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                var register = unitOfWork.RegisterRepository.GetByID(registerId);
                var documents = unitOfWork.DocumentRepository.GetByFilter(e => e.RegisterId == registerId);

                try
                {
                    unitOfWork.BeginTransaction();

                    if (documents?.Any() ?? false)
                    {
                        foreach (var document in documents)
                        {
                            unitOfWork.DocumentRepository.Delete(document);
                        }
                    }

                    unitOfWork.RegisterRepository.Delete(register);

                    unitOfWork.CommitTransaction();
                }
                catch
                {
                    unitOfWork.RollbackTransaction();
                    throw;
                }
            }
        }

        /// <summary>
        /// Получить полный список документов с разбивкой по показателям и их типам.
        /// </summary>
        /// <param name="registerId">Идентификатор реестра.</param>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Полный список документов с разбивкой по показателям и их типам.</returns>
        public List<ImportIndicatorType> GetImportIndicatorTypes(Guid registerId, Guid userId)
        {
            Argument.Require(registerId != Guid.Empty, "Не указан идентификатор реестра.");
            Argument.Require(userId != Guid.Empty, "Не указан идентификатор пользователя.");

            List<ImportIndicatorType> indicatorTypesList = new List<ImportIndicatorType>();
            double tempDouble;

            using (IUnitOfWork unitOfWork = _unitOfWorkFactory.Create(_configuration))
            {
                var user = unitOfWork.UserRepository.GetByID(userId);
                var register = unitOfWork.RegisterRepository.GetByID(registerId);

                var indicatorTypes = user.PositionId == PositionEnum.ZK
                    ? unitOfWork.IndicatorTypeRepository.GetAll()
                    : unitOfWork.IndicatorTypeRepository.GetAll()
                        .Where(e => e.IndicatorTypeId != IndicatorTypeEnum.Zvk);

                var indicators = unitOfWork.IndicatorRepository.GetAll();
                var documents = unitOfWork.DocumentRepository.GetByFilter(e => e.RegisterId == registerId);

                foreach (var indicatorType in indicatorTypes)
                {
                    var importIndicatorType = new ImportIndicatorType
                    {
                        IndicatorType = indicatorType,
                        Indicators = indicators
                            .Where(i => i.IndicatorTypeId == indicatorType.IndicatorTypeId)
                            .Select(i => new ImportIndicator
                            {
                                Indicator = i,
                                Documents = documents
                                    .Where(d => d.IndicatorId == i.IndicatorId)
                                    .ToList()
                            })
                            .ToList()
                    };

                    // Считаем общие суммы
                    importIndicatorType.Points = importIndicatorType.Indicators
                        .Sum(it =>
                            it.Documents
                                .Where(d => double.TryParse(d.Points, out tempDouble))
                                .Sum(d => Convert.ToDouble(d.Points)));

                    indicatorTypesList.Add(importIndicatorType);
                }

                return indicatorTypesList;
            }
        }
    }
}
