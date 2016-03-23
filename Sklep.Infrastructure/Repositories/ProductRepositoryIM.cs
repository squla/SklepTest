using domain.Product;
using domain.Product.Repositories;

namespace Sklep.Infrastructure.Repositories
{
    public class ProductRepositoryIM : GenericCRUDRepositories<Product>, IProductRepository
    {
        public override Product Find(int id)
        {
            Product tmpProduct = null;
            foreach (var p in list)
            {
                if (p.Id == id)
                {
                    tmpProduct = p;
                }
            }
            return tmpProduct;
        }

        public bool AddFeatures(int id, Feature f)
        {
            Product product = Find(id);
            if (product != null)
            {
                product.Features.Add(f);
                return true;
            }
            return false;
        }

        public bool RemoveFeatures(int id, Feature f)
        {
            Product product = Find(id);
            if (product != null)
            {
                product.Features.Remove(f);
                return true;
            }
            return false;
        }

        public void SetCategory(int id, Category category)
        {
            Product product = Find(id);
            if (product != null) product.Type = category;
        }
    }
}