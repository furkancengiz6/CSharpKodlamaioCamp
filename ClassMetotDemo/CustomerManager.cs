using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Musteri ismi :" + customer.Name + "Musteri Soyismi" + customer.Surname + "TC No:" + customer.TcNo+"/n"+"Müşteri Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri ismi :" + customer.Name + "Musteri Soyismi" + customer.Surname + "TC No:" + customer.TcNo + "/n" + "Müşteri Silindi");
        }
        public void CustomersList(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Musteri Adı:" + customer.Name);
            }
        }

    }
}
