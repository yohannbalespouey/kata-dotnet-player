namespace Api.Core.Users;

public class UserService
{
    public User GetUser(string id)
    {
        return UserMemoryRepository.FindUser(id);
    }

    public User CreateUser(string name)
    {
        var user = new User(name);
        UserMemoryRepository.Save(user);
        return user;
    }

    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }
}
