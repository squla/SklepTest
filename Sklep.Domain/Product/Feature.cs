using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Common;

namespace Sklep.Domain.Product
{
    public class Feature : Entity
    {
        public string Name { get; set; }
        public Object Value { get; set; }
    }
}
