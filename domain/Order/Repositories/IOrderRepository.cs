using Sklep.GenericComponent;

namespace domain.Order.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        void AddProduct(int id, Product.Product p);
        void RemoveProduct(int id, Product.Product p);

    }
}