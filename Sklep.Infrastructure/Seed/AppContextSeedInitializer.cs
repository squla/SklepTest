using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Sklep.Domain.Customer;
using Sklep.Domain.Entities;
using Sklep.Domain.Product;

namespace Sklep.Infrastructure.Seed
{
    public class AppContextSeedInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            context.Users.Add(new User(
                "TestLogin",
                "test123",
                "test123@2p.pl",
                new Customer(
                    "FirstName",
                    "LastName",
                    "123123123",
                    new CustomerAdress
                    {
                        Adress1 = "Adress1",
                        Adress2 = "Adress2",
                        City = "City",
                        Country = "Country"
                    }

                        )));
           
            context.SaveChanges();
        }
    }
}