using Sklep.GenericComponent;

namespace Sklep.Domain.Product.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        bool AddFeatures(int id, Feature f);
        bool RemoveFeatures(int id, Feature f);
        void SetCategory(int id, Category category);
    }
}