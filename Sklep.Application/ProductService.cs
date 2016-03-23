using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using domain.Product;
using domain.Product.Repositories;
using Sklep.Application.Interfaces;
using Sklep.Infrastructure.Repositories;

namespace Sklep.Application
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepositoryIM();
        }

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public IList<Product> GetAllProducts()
        {
            return _productRepository.FindAll();
        }

        public bool AddNewProduct(Product p)
        {
            return _productRepository.Insert(p);
        }

        public bool RemoveProduct(Product p)
        {
            return _productRepository.Delete(p.Id) != null;
        }

        public bool AddFeatures(int id, Feature f)
        {
            return _productRepository.AddFeatures(id, f);
        }

        public bool RemoveFeatures(int id, Feature f)
        {
            return _productRepository.RemoveFeatures(id, f);
        }

        public void SetCategory(int id, Category category)
        {
            _productRepository.SetCategory(id, category);
        }
    }
}