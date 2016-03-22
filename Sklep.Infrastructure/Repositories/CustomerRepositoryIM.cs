using System;
using domain.Customer;

namespace Sklep.Infrastructure.Repositories
{
    public class CustomerRepositoryIM : GenericCRUDRepositories<Customer>
    {
        
        public override Customer Find(int id)
        {
            Customer tmpCustomer = null;
            foreach (var c in list)
            {
                if (c.Id == id)
                {
                    tmpCustomer = c;
                }
            }
            return tmpCustomer;
        }
    }
}