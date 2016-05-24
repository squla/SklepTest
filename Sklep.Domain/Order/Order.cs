using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Common;
using Sklep.Domain.Product;
namespace Sklep.Domain.Order
{
    public class Order : Entity
    {
        //public int Id;
        public Order()
        {
            Products = new HashSet<Product.Product>();
        }

        public virtual ICollection<Product.Product> Products { get; set; }
        public float Amount { get; set; }
       // public ShipmentStatusEnum ShipmentStatus { get; set; }
       // public DeliveryStatusEnum DeliveryStatus { get; set; }
       // public PaymentType Payment { get; set; }
        //public Customer.Customer OwnerCostomer { get; set; }
    }
}
