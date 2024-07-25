using ClassMetotDemo;
using System.Collections.Generic;
using System.ComponentModel;



internal class Program
{
    private static void Main(string[] args)
    {
        Customer musteri = new Customer();
        musteri.Id = 1;
        musteri.Ad = "Berkay";
        musteri.Soyad = "Şahin";

        Customer musteri1 = new Customer();
        musteri1.Id = 2;
        musteri1.Ad = "Mehmet";
        musteri1.Soyad = "Emin";

        CustomerManager manage = new CustomerManager();
        manage.CustomerAdd(musteri);
        Customer[] customers = new Customer[] { musteri, musteri1 };
        manage.List(customers);
        manage.Delete(musteri1);
    }
}