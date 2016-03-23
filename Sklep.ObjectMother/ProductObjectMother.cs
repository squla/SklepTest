using System.CodeDom;
using System.Collections.Generic;
using domain.Product;

namespace Sklep.ObjectMother
{
    public class ProductObjectMother
    {
        public static Product CreateProductWithNoFeatures()
        {
            return new Product
            {
                Id = 1, 
                Name = "Żelka",
                Price = 1.0F,
                Type = new Category(),
                Features = new List<Feature>()
            };
        }

        public static Category CreateCategory()
        {
            return new Category {Name = "Słodycze"};
        }

        public static Feature CreateFeature()
        {
            return new Feature
            {
                Name = "Waga",
                Value = 100
            };
        }
    }
}