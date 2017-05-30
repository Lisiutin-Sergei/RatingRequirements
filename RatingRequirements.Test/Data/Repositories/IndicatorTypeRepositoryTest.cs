using Microsoft.VisualStudio.TestTools.UnitTesting;
using RatingRequirements.Data.UnitOfWork;

namespace RatingRequirements.Test.Data.Repositories
{
    /// <summary>
    /// Тесты для репозитория типов показателей.
    /// </summary>
    [TestClass]
    public class IndicatorTypeRepositoryTest : BaseTest
    {
        /// <summary>
		/// Доолжен получить все типы пользователей.
		/// </summary>
		[TestMethod]
        public void ShouldGetAllIndicatorTypes()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.IndicatorTypeRepository.GetAll();
                Assert.IsNotNull(list);
            }
        }
    }
}
