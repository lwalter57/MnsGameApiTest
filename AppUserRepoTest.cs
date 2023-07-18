using WebAPI_MNS_Games.Models;

namespace MNSApiTest
{
    [TestClass]
    public class AppUserRepoTest
    {
        public AppUserRepositoryMoq _appUserRepositoryMoq { get; set; }

        [TestInitialize]
        public void init()
        {
            _appUserRepositoryMoq= new AppUserRepositoryMoq();
        }
        [TestMethod]
        public void GetAllAppUSers_ShouldReturnAIEnumerable()
        {
            //Jeu de données
            var appUSerTest1 = new AppUser()
            {
                LoginNickname = "test",
                LoginPassword= "test",
                Email= "test@test.com"
            };
            var appUSerTest2 = new AppUser()
            {
                LoginNickname = "test2",
                LoginPassword = "test2",
                Email = "test2@test.com"
            };

            _appUserRepositoryMoq.AppUsers.Add(appUSerTest1);
            _appUserRepositoryMoq.AppUsers.Add(appUSerTest2);

            //test
            var testList = _appUserRepositoryMoq.GetAllUsers();

            //Assert
            Assert.IsInstanceOfType(testList, typeof(IEnumerable<AppUser>));
        }
    }
}