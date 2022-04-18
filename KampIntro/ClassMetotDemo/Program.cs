using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* İSTERLER
             * Bir bankada müşteri takibi yapmak istiyorsunuz.
             * Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
             * MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
             */

            // müşteri örnekleri oluşturuldu
            Customer customer1 = new Customer() { Id = 1, FirstName = "Muzaffer", LastName = "Bulut" };
            Customer customer2 = new Customer() { Id = 2, FirstName = "Ferhat", LastName = "Bulut" };
            Customer customer3 = new Customer() { Id = 3, FirstName = "Samed", LastName = "Adalı" };
            Customer customer4 = new Customer() { Id = 4, FirstName = "Salih", LastName = "Dinç" };

            // müşteri listesi
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            Console.WriteLine();
            customerManager.DelCustomer(customer1);
            Console.WriteLine();
            customerManager.ListCustomer(customers);
        }
    }
}
