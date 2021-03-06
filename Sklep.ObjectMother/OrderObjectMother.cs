﻿using System;
using System.Collections.Generic;
using Sklep.Domain.Order;
using Sklep.Domain.Product;

namespace Sklep.ObjectMother
{
    public class OrderObjectMother
    {
        public static Order CreateEmptyOrder()
        {
            return new Order
            {
                Id = new Guid(),
                Products = new List<Product>(),
                Amount = 0F
            };
        } 
    }
}