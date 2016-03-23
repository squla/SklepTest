using System.Collections.Generic;
using Sklep.Domain.Order;
using Sklep.Domain.Product;

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