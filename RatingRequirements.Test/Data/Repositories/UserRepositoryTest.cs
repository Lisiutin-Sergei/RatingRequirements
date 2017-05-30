using Microsoft.VisualStudio.TestTools.UnitTesting;
using RatingRequirements.Core.Model;
using RatingRequirements.Data.UnitOfWork;
using RatingRequirements.Utilities.ExtensionMethods;
using System.Linq;

namespace RatingRequirements.Test.Data.Repositories
{
    /// <summary>
    /// Тесты для репозитория пользователей.
    /// </summary>
    [TestClass]
    public class UserRepositoryTest : BaseTest
    {
        /// <summary>
        /// Доолжен получить пользователя по идентификатору.
        /// </summary>
        [TestMethod]
        public void ShouldGetUserById()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.UserRepository.GetAll();
                Assert.IsNotNull(list);

                if (list.Any())
                {
                    var user = list.First();
                    var foundUser = unitOfWork.UserRepository.GetByID(user.UserId);
                    Assert.IsNotNull(foundUser);
                    Assert.IsInstanceOfType(foundUser, typeof(User));
                    Assert.AreEqual(user.UserId, foundUser.UserId);
                }
            }
        }

        /// <summary>
		/// Доолжен получить всех пользователей.
		/// </summary>
		[TestMethod]
        public void ShouldGetAllUsers()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.UserRepository.GetAll();
                Assert.IsNotNull(list);
            }
        }
        
        /// <summary>
        /// Доолжен получить пользователей по фильтру.
        /// </summary>
        [TestMethod]
        public void ShouldGetUsersByFilter()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                var list = unitOfWork.UserRepository.GetByFilter(null);
                var fullList = unitOfWork.UserRepository.GetAll();
                Assert.AreEqual(list.Count(), fullList.Count());

                if (list.Count() > 0)
                {
                    var user = unitOfWork.UserRepository
                        .GetByFilter(e => e.Login.EqualsIgnoreCase(list.First().Login));
                    Assert.AreEqual(1, user.Count());
                    Assert.AreEqual(list.First().Login, user.First().Login);
                }
                
            }
        }

        /// <summary>
		/// Тест CRUD.
		/// </summary>
		[TestMethod]
        public void ShouldCrudUser()
        {
            var configuration = GetConfiguration();
            using (UnitOfWork unitOfWork = new UnitOfWork(configuration))
            {
                User user = null;
                try
                {
                    // Create
                    user = new User()
                    {
                        Name = "Test User",
                        Login = "testuser",
                        PasswordHash = "passhash"
                    };
                    var userId = unitOfWork.UserRepository.Insert(user);


                    // Read
                    user = unitOfWork.UserRepository.GetByID(userId);
                    Assert.IsNotNull(user);
                    Assert.AreEqual(userId, user.UserId);

                    // Update
                    user.Name = "Updated User Name";
                    unitOfWork.UserRepository.Update(user);

                    user = unitOfWork.UserRepository.GetByID(userId);
                    Assert.IsNotNull(user);
                    Assert.AreEqual(userId, user.UserId);
                    Assert.AreEqual("Updated User Name", user.Name);

                    // Delete
                    unitOfWork.UserRepository.Delete(user);
                    user = unitOfWork.UserRepository.GetByID(userId);
                    Assert.IsNull(user);
                }
                finally
                {
                    if (user != null)
                    {
                        unitOfWork.UserRepository.Delete(user);
                    }
                }
            }
        }
    }
}
