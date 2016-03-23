using System.Collections.Generic;
using Sklep.Domain.Order;
using Sklep.Domain.Order.Repositories;
using Sklep.Domain.Product;
using Sklep.Application.Interfaces;
using Sklep.Infrastructure.Repositories;

namespace Sklep.Application
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepositoryIM();
        }

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IList<Order> GetAllOrders()
        {
            return _orderRepository.FindAll();
        }

        public bool AddNewOrder(Order o)
        {
            return _orderRepository.Insert(o);
        }

        public bool RemoveOrder(int orderId)
        {
            return _orderRepository.Delete(orderId) != null;
        }

        public void AddProduct(int orderId, Product p)
        {
            _orderRepository.AddProduct(orderId, p);
        }

        public void RemoveProduct(int orderedId, Product p)
        {
            _orderRepository.RemoveProduct(orderedId, p);
        }
    }
}