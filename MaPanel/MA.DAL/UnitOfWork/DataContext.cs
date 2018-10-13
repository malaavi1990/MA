using MA.Domain;
using System.Data.Entity;

namespace MA.DAL.UnitOfWork
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }


        // Domain Classes
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
