using Apiauth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Apiauth.Data;

namespace Apiauth.Repositories
{
 
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDataContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=auth;User Id=sa;Password=Password321;");
            using (var context = new AppDataContext(optionsBuilder.Options))
            {
                return context.Users.AsNoTracking().FirstOrDefault(x => x.Username == username && x.Password == password);
            }
        }
    }
}