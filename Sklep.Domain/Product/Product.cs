using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Common;

namespace Sklep.Domain.Product
{
    public class Product : Entity
    {
        //public int Id { get; set; }
        public Product()
        {
            Features = new HashSet<Feature>();
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public Category Type { get; set; }
        public virtual ICollection<Feature> Features { get; set; } 
    }
}
