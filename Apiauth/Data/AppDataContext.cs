using Apiauth.Models;
using Microsoft.EntityFrameworkCore;

namespace Apiauth.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=auth;User Id=sa;Password=Password321;");
        }
        public DbSet<User> Users { get; set; }

    }
}