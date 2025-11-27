using Api.Core.Users;

namespace Api.UnitTests.Core
{
    public class Step1UserServiceTests
    {
        [Fact]
        public void Test_CreateUser()
        {
            var sut = new UserService();
            var createdUser = sut.CreateUser("John Doe");
            Assert.NotNull(createdUser);
            Assert.Equal("John Doe", createdUser.Name);
        }

        [Fact]
        public void Test_GetUser()
        {
            var sut = new UserService();
            var createdUser = sut.CreateUser("John Doe");

            var user = sut.GetUser(createdUser.Id);
            Assert.Equal(createdUser, user);
        }

        [Fact]
        public void Test_DeleteUser()
        {
            var sut = new UserService();
            var user1 = sut.CreateUser("John Doe");
            sut.DeleteUser(user1);

            Assert.Null(sut.GetUser(user1.Id));
        }
    }
}