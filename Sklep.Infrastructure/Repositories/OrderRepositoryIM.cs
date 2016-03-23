using domain.Order;
using domain.Order.Repositories;
using domain.Product;

namespace Sklep.Infrastructure.Repositories
{
    public class OrderRepositoryIM : GenericCRUDRepositories<Order>, IOrderRepository
    {
        public override Order Find(int id)
        {
            Order tmpOrder = null;
            foreach (var o in list)
            {
                if (o.Id == id)
                {
                    tmpOrder = o;
                }
            }
            return tmpOrder;
        }

        public void AddProduct(int id, Product p)
        {
            Order o = Find(id);
            if (o != null)
            {
                o.Products.Add(p);
                o.Amount += p.Price;
            }
        }

        public void RemoveProduct(int id, Product p)
        {
            Order o = Find(id);
            if (o != null)
            {
                o.Products.Remove(p);
                o.Amount -= p.Price;
            }
        }
    }
}