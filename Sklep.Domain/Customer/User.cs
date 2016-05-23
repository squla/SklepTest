using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Sklep.Common;

namespace Sklep.Domain.Entities
{
    public class User : Entity
    {
      
        public String Login { get; set; }
        private string _hashPassword;
        public String Email { get; set; }
        public Boolean ConfirmedEmail { get; set; }
        public Customer.Customer Customer { get; set; }

        public User() { }
        public User(String login,String password, String email, Customer.Customer customer)
        {
            this.Login = login;
            this.Email = email;
            this.ConfirmedEmail = true;
            this.Customer = customer;
            CalcMD5(password);
        }

        private void CalcMD5(String password)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            this._hashPassword = BitConverter.ToString(hash)
               .Replace("-", string.Empty)
               .ToLower();
        }
    }
}
