namespace Api.Core.Users
{
    public class UserMemoryRepository
    {
        private static Dictionary<string, User> _users = new Dictionary<string, User>();

        public static User FindUser(string id)
        {
            return _users[id];
        }

        public static void Save(User user)
        {
            _users.Add(user.Id, user);
        }

        public static void Delete(string id)
        {
            _users.Remove(id);
        }
    }
}
