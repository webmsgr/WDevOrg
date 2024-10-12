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
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
