using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Application.Interfaces;
using Sklep.ObjectMother;

/**
namespace Sklep.Application.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        
        IOrderService iOrderService = new OrderService();
        [TestMethod()]
        public void GetAllOrdersTest()
        {
            Assert.IsTrue(iOrderService.GetAllOrders().Count == 0);
        }

        [TestMethod()]
        public void AddNewOrderTest()
        {
            iOrderService.AddNewOrder(OrderObjectMother.CreateEmptyOrder());
            Assert.IsTrue(iOrderService.GetAllOrders().Count == 1); ;
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            iOrderService.RemoveOrder(1);
            Assert.IsTrue(iOrderService.GetAllOrders().Count == 0);
        }

        [TestMethod()]
        public void AddProductTest()
        {
            iOrderService.AddNewOrder(OrderObjectMother.CreateEmptyOrder());
            Assert.IsTrue(iOrderService.GetAllOrders().Count == 1); ;
            iOrderService.AddProduct(iOrderService.GetAllOrders().First().Id, ProductObjectMother.CreateProductWithNoFeatures());
            Assert.IsTrue(iOrderService.GetAllOrders().First().Products.Count > 0);
        }

        [TestMethod()]
        public void RemoveProductTest()
        {
            iOrderService.AddNewOrder(OrderObjectMother.CreateEmptyOrder());
            Assert.IsTrue(iOrderService.GetAllOrders().Count == 1);
            iOrderService.AddProduct(iOrderService.GetAllOrders().First().Id, ProductObjectMother.CreateProductWithNoFeatures());
            Assert.IsTrue(iOrderService.GetAllOrders().First().Products.Count > 0);
            iOrderService.RemoveProduct(1, ProductObjectMother.CreateProductWithNoFeatures());
        }
    }
}
    **/