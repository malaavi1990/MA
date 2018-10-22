using MA.Domain;
using System.Data.Entity;
using MA.DAL.Configurations;

namespace MA.DAL.UnitOfWork
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurations
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new RoleConfig());
        }

        // Domain Classes
        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<SiteSection> SiteSections { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<News> Newses { get; set; }
    }
}
