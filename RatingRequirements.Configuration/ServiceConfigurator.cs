using Microsoft.Extensions.Configuration;
using Ninject;
using RatingRequirements.Core.Interface;
using RatingRequirements.Core.Interface.Repository;
using RatingRequirements.Core.Interface.Service;
using RatingRequirements.Core.Service;
using RatingRequirements.Data;
using RatingRequirements.Data.Repositories;
using RatingRequirements.Data.UnitOfWork;

namespace RatingRequirements.Configuration
{
    /// <summary>
    /// Конфигуратор сервисов для контейнера зависимостей.
    /// </summary>
    public class ServiceConfigurator
    {
        public static void ConfigureServices(IKernel kernel, IConfiguration configuration)
        {
            kernel.Bind<IConfiguration>().ToMethod((serviceProvider) => configuration).InSingletonScope();

            ConfigureCoreServices(kernel);
            ConfigureDataServices(kernel);
            ConfigureUtilitiesServices(kernel);
        }

        /// <summary>
        /// Задать зависимости проекта .Core.
        /// </summary>
        /// <param name="kernel">Ядро IoC.</param>
        private static void ConfigureCoreServices(IKernel kernel)
        {
            kernel.Bind<IUserService>().To<UserService>().InTransientScope();
            kernel.Bind<IRegisterService>().To<RegisterService>().InTransientScope();
            kernel.Bind<IIndicatorTypeService>().To<IndicatorTypeService>().InTransientScope();
            kernel.Bind<IIndicatorService>().To<IndicatorService>().InTransientScope();
            kernel.Bind<IDocumentService>().To<DocumentService>().InTransientScope();
        }

        /// <summary>
        /// Задать зависимости проекта .Data.
        /// </summary>
        /// <param name="kernel">Ядро IoC.</param>
        private static void ConfigureDataServices(IKernel kernel)
        {
            FluentMappingConfiguration.ConfigureMapping();
            kernel.Bind<IUnitOfWorkFactory>().To<UnitOfWorkFactory>().InTransientScope();

            kernel.Bind<IUserRepository>().To<UserRepository>().InTransientScope();
            kernel.Bind<IRegisterRepository>().To<RegisterRepository>().InTransientScope();
            kernel.Bind<IIndicatorTypeRepository>().To<IndicatorTypeRepository>().InTransientScope();
            kernel.Bind<IIndicatorRepository>().To<IndicatorRepository>().InTransientScope();
            kernel.Bind<IDocumentRepository>().To<DocumentRepository>().InTransientScope();
            kernel.Bind<IPositionRepository>().To<PositionRepository>().InTransientScope();
        }

        /// <summary>
        /// Задать зависимости проекта .Utilities.
        /// </summary>
        /// <param name="kernel">Ядро IoC.</param>
        private static void ConfigureUtilitiesServices(IKernel kernel)
        {
        }
    }
}
