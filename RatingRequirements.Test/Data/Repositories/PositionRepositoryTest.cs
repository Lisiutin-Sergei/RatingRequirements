using Microsoft.VisualStudio.TestTools.UnitTesting;
using RatingRequirements.Core.Model;
using RatingRequirements.Data.UnitOfWork;
using RatingRequirements.Utilities.ExtensionMethods;
using System.Linq;

namespace RatingRequirements.Test.Data.Repositories
{
    /// <summary>
    /// Тесты для репозитория должностей.
    /// </summary>
    [TestClass]
    public class PositionRepositoryTest : BaseTest
    {
        /// <summary>
		/// Доолжен получить все должности.
		/// </summary>
		[TestMethod]
        public void ShouldGetAllPositions()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.PositionRepository.GetAll();
                Assert.IsNotNull(list);
            }
        }
    }
}
