using System.Collections.Generic;

namespace Api.Core.Users
{
    public class User
    {
        public string Id { get; }

        public string Name { get; }

        public User(string name)
        {
            Id = Guid.NewGuid().ToString("N");
            Name = name;
        }
    }
}
