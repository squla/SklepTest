using System.Collections.Generic;
using domain.Order;
using domain.Product;

namespace Sklep.Application.Interfaces
{
    public interface IOrderService
    {
        IList<Order> GetAllOrders();
        bool AddNewOrder(Order o);
        bool RemoveOrder(int orderId);
        void AddProduct(int orderedId, Product p);
        void RemoveProduct(int orderedId, Product p);
    }
}