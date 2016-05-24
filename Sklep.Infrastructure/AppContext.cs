using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Sklep.Domain.Customer;
using Sklep.Domain.Entities;
using Sklep.Domain.Order;
using Sklep.Domain.Product;
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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}