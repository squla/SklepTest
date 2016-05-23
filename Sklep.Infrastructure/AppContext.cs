using System.Data.Entity;
using Sklep.Domain.Entities;
using Sklep.Infrastructure.Seed;

namespace Sklep.Infrastructure
{
    public class AppContext : DbContext
    {
        public AppContext() : base("Sklep")
        {
            Database.SetInitializer(new AppContextSeedInitializer());
        } 

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}