using System;
using System.ComponentModel.DataAnnotations;

namespace Sklep.Common
{
    public abstract class Entity
    {
        [Key]
         public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}