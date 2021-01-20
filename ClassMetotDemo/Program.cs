using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri()
            {
                Id = 100,
                Ad = "Alexi",
                Soyad = "Laiho",
                Yas = 41,
                Cinsiyet = "Erkek",
                Hometown = "Helsinki - Finland"
            };

            Musteri customer2 = new Musteri()
            {
                Id = 99,
                Ad = "Gene",
                Soyad = "Haas",
                Yas = 75,
                Cinsiyet = "Erkek",
                Hometown = "Ohio - USA"
            };

            Musteri[] customers = new Musteri[]
        {
            customer1, customer2
        };
            foreach (var Musteri in customers)
            {
                Console.WriteLine("Ad: " +Musteri.Ad);
                Console.WriteLine("Soyad: "  +Musteri.Soyad);
                Console.WriteLine("Yaş: " +Musteri.Yas);
                Console.WriteLine("Cinsiyet: " +Musteri.Cinsiyet);
                Console.WriteLine("Şehir: " +Musteri.Hometown);
                Console.WriteLine();
            }

            MusteriManager manager = new MusteriManager();
            manager.AddCustomer(customer1);
            manager.AddCustomer(customer2);
            manager.DeleteCustomer(customer2);
            
        }
    }

    
}
