using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {

        public void CustomerAdd(Customer customer) 
        {
            Console.WriteLine("Id Eklendi" + customer.Id);
            Console.WriteLine("İsim Eklendi" + customer.Ad);
            Console.WriteLine("Soyad Eklendi" + customer.Soyad);
        }
     
        public void Delete(Customer customer)
        {
            Console.WriteLine("Id Silindi" + customer.Id);
            Console.WriteLine("İsim Silindi" + customer.Ad);
            Console.WriteLine("Soyad Silindi" + customer.Soyad);
        }

        public void List(Customer[] customers) {

            foreach (Customer musteriler in customers)
            {
                Console.WriteLine(musteriler.Ad + "\n" + musteriler.Soyad + "\n" + musteriler.Id);
                Console.WriteLine("********");
            }
        }
    }
}
