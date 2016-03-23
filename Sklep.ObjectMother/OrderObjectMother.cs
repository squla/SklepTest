using System.Collections.Generic;
using domain.Order;
using domain.Product;

namespace Sklep.ObjectMother
{
    public class OrderObjectMother
    {
        public static Order CreateEmptyOrder()
        {
            return new Order
            {
                Id = 1,
                Products = new List<Product>(),
                Amount = 0F
            };
        } 
    }
}