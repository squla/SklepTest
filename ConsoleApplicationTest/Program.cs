using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sklep.Domain.Entities;
using Sklep.Infrastructure;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AppContext())
            {
                ctx.Users.Add(new User());
                ctx.SaveChanges();
            }
        }
    }
}
