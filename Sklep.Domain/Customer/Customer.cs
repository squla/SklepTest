using Sklep.Common;

namespace Sklep.Domain.Customer
{
    public class Customer
    {
     //   public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public CustomerAdress Adress {get; set;}

        public Customer() { }
        public Customer(string firstName, string lastName, string phone1, CustomerAdress customerAdress)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone1 = phone1;
            Adress = customerAdress;
        }

    }
}
