using RefreshTokenAuth.Models;

namespace RefreshTokenAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "user", Password = "user", Role = "user" });
            users.Add(new User { Id = 2, Username = "admin", Password = "admin", Role = "admin" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

        internal static void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}