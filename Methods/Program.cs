using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 7.15;
            product1.Description = "Amasya apple";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Pear";
            product2.Price = 9.59;
            product2.Description = "Juicy pear";

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Orange";
            product3.Price = 3.99;
            product3.Description = "Fenike's juicy orange";

            Product[] products = new Product[]
            {
                product1,
                product2,
                product3
            };

            // Type safe 
            foreach (Product item in products)
            {
                Console.WriteLine("Name: " + item.Name + "\nPrice: " + item.Price + "\nDescription: " + item.Description + "\n");
            }

            Console.WriteLine("--------------Methods--------------");

            // instance ~ ornek
            // encapsulation
            BasketManager basketManager1 = new BasketManager();
            basketManager1.Add(product1);
            basketManager1.Add(product2);
            basketManager1.Add(product3);
            Console.WriteLine();
            basketManager1.Add2("Apple", 8.15, "Amasya's apple", 13);
            basketManager1.Add2("Pear", 3.15, "Juicy pear", 11);
            basketManager1.Add2("Orange", 1.10, "Fenike", 55);
        }
    }
}
// Do not repeat yourself