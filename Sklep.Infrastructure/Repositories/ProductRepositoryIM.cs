using domain.Product;

namespace Sklep.Infrastructure.Repositories
{
    public class ProductRepositoryIM : GenericCRUDRepositories<Product>
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
    }
}