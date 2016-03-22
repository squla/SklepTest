using domain.Order;

namespace Sklep.Infrastructure.Repositories
{
    public class OrderRepositoryIM : GenericCRUDRepositories<Order>
    {
        public override Order Find(int id)
        {
            Order tmpOrder = null;
            foreach (var o in list)
            {
                if (o.Id == id)
                {
                    tmpOrder = o;
                }
            }
            return tmpOrder;
        }
    }
}