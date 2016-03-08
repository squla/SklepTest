using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.ValueObjects;

namespace domain.Entities
{
    class Order
    {
        public virtual ICollection<Product> Products { get; set; }
        public float Amount { get; set; }
        public Object ShipmentStatus { get; set; }
        public Object DeliveryStatus { get; set; }
        public PaymentType Payment { get; set; }
        public Costomer OwnerCostomer { get; set; }
    }
}
