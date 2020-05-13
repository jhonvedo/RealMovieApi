using Microsoft.EntityFrameworkCore;
using RealMovieContext.Models;

namespace RealMovieContext
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }


        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<User>()
                .HasAlternateKey(a => a.UserName);
        }

    }
}
