using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.ValueObjects;

namespace domain.Entities
{
    class Costomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public CustomerAdress Adress {get; set;}

    }
}
