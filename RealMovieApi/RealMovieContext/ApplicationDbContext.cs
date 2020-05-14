using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealMovieContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMovieContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var user = new ApplicationUser
            {
                FirstName = "Jhon",
                LastName = "Acevedo",
                Email = "jhon.vedo@gmail.com",
                NormalizedEmail = "JHON.VEDO@GMAIL.COM",
                UserName = "jhon.vedo@gmail.com",
                NormalizedUserName = "JHON.VEDO@GMAIL.COM",               
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                IsAdmin=true
            };
            var password = new PasswordHasher<ApplicationUser>();
            var hashed = password.HashPassword(user, "America2020*");
            user.PasswordHash = hashed;

            _ = builder.Entity<ApplicationUser>().HasData(user);
        }
    }
}