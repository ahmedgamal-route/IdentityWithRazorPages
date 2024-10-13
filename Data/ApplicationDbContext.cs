using IdentityWithRazorPages.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityWithRazorPages.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>().ToTable("Users", "Security");

            builder.Entity<IdentityRole>().ToTable("Roles", "Security");

            builder.Entity<IdentityUserRole<string>>().ToTable("UsersRole", "Security");

            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Security");

            builder.Entity<IdentityUserLogin<string>>().ToTable("UsersLogin", "Security");

            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleCalims", "Security");

            builder.Entity<IdentityUserToken<string>>().ToTable("UsersToken", "Security");




        }
    }
}
