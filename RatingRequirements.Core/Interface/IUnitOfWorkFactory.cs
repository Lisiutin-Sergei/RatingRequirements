using Microsoft.Extensions.Configuration;

namespace RatingRequirements.Core.Interface
{
    /// <summary>
	/// Фабрика единиц работы.
	/// </summary>
	public interface IUnitOfWorkFactory
    {
        /// <summary>
        /// Создать новую единицу работы с заданной конфигурацией.
        /// </summary>
        /// <param name="configuration">Конфигурация для единицы работы.</param>
        /// <returns>Экземпляр единицы работы.</returns>
        IUnitOfWork Create(IConfiguration configuration);
    }
}
