using ClassMetotDemo;
using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Furkan";
            customer.Surname = "Cengiz";
            Customer customer2 = new Customer();
            customer2.Name = "Ali";
            customer2.Surname = "Veli";
            Customer customer3 = new Customer();
            customer3.Name = "Mehmet";
            customer.Surname = "asdsa";


            CustomerManager manager = new CustomerManager();
            manager.Add(customer);
            Customer[] customers = new Customer[] { customer, customer2 };
            manager.CustomersList(customers);

        }
    }
}