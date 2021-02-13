using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        // Name convention
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations! Added to basket : " + product.Name);
        }

        public void Add2(string productName, double price, string description, int stockAmount)
        {
            Console.WriteLine("Congratulations! Added to basket : " + productName);

        }
    }
}
