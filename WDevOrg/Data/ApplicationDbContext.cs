using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WDevOrg.Models;

namespace WDevOrg.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var editorJsonConverter = new EditorJsonConverter();

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasConversion(editorJsonConverter);
            });
            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Content)
                    .HasConversion(editorJsonConverter);
            });

            base.OnModelCreating(modelBuilder);

            // seed data
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "af4c9970-044a-4659-b3e8-4e96d5fa73a1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "00164e93-b93d-444d-b942-38498b006168", Name = "User", NormalizedName = "USER" }
            );
            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "3aabfbac-d2ad-490d-86e4-60f93f593830",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "TmGLjnBWrhhaQwMF")
                }
            );


            //Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "af4c9970-044a-4659-b3e8-4e96d5fa73a1",
                    UserId = "3aabfbac-d2ad-490d-86e4-60f93f593830"
                }
            );
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
