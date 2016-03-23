using System.Collections.Generic;
using domain.Product;

namespace Sklep.Application.Interfaces
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        bool AddNewProduct(Product p);
        bool RemoveProduct(Product p);
        bool AddFeatures(int id, Feature f);
        bool RemoveFeatures(int id, Feature f);
        void SetCategory(int id, Category category);
    }
}