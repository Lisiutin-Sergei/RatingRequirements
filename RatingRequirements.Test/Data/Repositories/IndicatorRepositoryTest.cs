using Microsoft.VisualStudio.TestTools.UnitTesting;
using RatingRequirements.Data.UnitOfWork;

namespace RatingRequirements.Test.Data.Repositories
{
    /// <summary>
    /// Тесты для репозитория показателей.
    /// </summary>
    [TestClass]
    public class IndicatorRepositoryTest : BaseTest
    {
        /// <summary>
		/// Доолжен получить всех пользователей.
		/// </summary>
		[TestMethod]
        public void ShouldGetAllIndicators()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.IndicatorRepository.GetAll();
                Assert.IsNotNull(list);
            }
        }
    }
}
