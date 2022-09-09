using Apiauth.Models;
using Microsoft.EntityFrameworkCore;

namespace Apiauth.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}