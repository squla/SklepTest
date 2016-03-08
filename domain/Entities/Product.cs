using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.ValueObjects;

namespace domain.Entities
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Category Type { get; set; }
        public virtual ICollection<Feature> Features { get; set; } 
    }
}
