using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Domain.Product;
namespace Sklep.Domain.Order
{
    public class Order
    {
        public int Id;
        public virtual ICollection<Product.Product> Products { get; set; }
        public float Amount { get; set; }
        public Object ShipmentStatus { get; set; }
        public Object DeliveryStatus { get; set; }
        public PaymentType Payment { get; set; }
        public Customer.Customer OwnerCostomer { get; set; }
    }
}
