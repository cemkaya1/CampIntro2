using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New customer " + customer.Name + " " + customer.Lastname + " added!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Lastname + " updated!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer " + customer.Name + " " + customer.Lastname + " deleted!");
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + "." + " Customer: " + customer.Name + " " + customer.Lastname + "," + "Identity Number: " + customer.IdentityNumber);
            }
        }
    }
}
