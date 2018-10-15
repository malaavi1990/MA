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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
