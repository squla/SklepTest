using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sklep.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Product;
using Sklep.Application.Interfaces;
using Sklep.ObjectMother;

namespace Sklep.Application.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        IProductService iProductService = new ProductService();
        [TestMethod()]
        public void GetAllProductsTest()
        {
            IList<Product> test = iProductService.GetAllProducts();
            Assert.IsTrue(test.Count == 0);
        }

        [TestMethod()]
        public void AddNewProductTest()
        {
            iProductService.AddNewProduct(ObjectMother.ProductObjectMother.CreateProductWithNoFeatures());
            IList<Product> test = iProductService.GetAllProducts();

            Assert.IsTrue(test.Count == 1);
            Assert.AreEqual(test.FirstOrDefault().Id, ObjectMother.ProductObjectMother.CreateProductWithNoFeatures().Id);
        }

        

        [TestMethod()]
        public void RemoveProductTest()
        {
            iProductService.AddNewProduct(ObjectMother.ProductObjectMother.CreateProductWithNoFeatures());
            IList<Product> test = iProductService.GetAllProducts();

            Assert.IsTrue(test.Count == 1);
            Assert.AreEqual(test.FirstOrDefault().Id, ObjectMother.ProductObjectMother.CreateProductWithNoFeatures().Id);
            iProductService.RemoveProduct(test.FirstOrDefault());
            Assert.IsTrue(iProductService.GetAllProducts().Count == 0);

        }

        [TestMethod()]
        public void AddFeaturesTest()
        {
            iProductService.AddNewProduct(ObjectMother.ProductObjectMother.CreateProductWithNoFeatures());
            IList<Product> test = iProductService.GetAllProducts();

            Assert.IsTrue(test.Count == 1);

        }

        [TestMethod()]
        public void RemoveFeaturesTest()
        {

            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SetCategoryTest()
        {
            Assert.IsTrue(true);
        }
    }
}