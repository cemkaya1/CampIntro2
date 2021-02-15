using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize customer1
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ahmet";
            customer1.Lastname = "Okan";
            customer1.IdentityNumber = "11111111111";

            // Initialize customer2
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ayse";
            customer2.Lastname = "Emine";
            customer2.IdentityNumber = "22222222222";

            Customer[] customers = { customer1, customer2 };

            // Initialize an object from CustomerManager class
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer1);
            customer2.Lastname = "Fatma";
            customerManager.Update(customer2);

            customerManager.List(customers);
        }
    }
}
