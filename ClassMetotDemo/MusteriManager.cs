using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Musteri customer)
        {
            Console.WriteLine("Müşteri eklendi! " + customer.Ad + " "+ customer.Soyad);
            Console.WriteLine();
        }
        public void DeleteCustomer(Musteri customer)
        {
            Console.WriteLine("Müşteri silindi! " + customer.Ad + " " + customer.Soyad);
            Console.WriteLine();
        }

        

        
    }
}
