using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz. Strabucks ve Nero
            firması için çalışıyoruz. İki firma da müşterilerini veri tabanına kaydetmek istiyor. Starbucks
            müşterileri kaydederken mutlaka mernis doğrulaması istiyor ancak nero böyle bir şey istemiyor.
            Starbucks müşteriler için her kahve alımında yıldız kazandırmak istiyor.
             */

            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,10,20), FirstName="Muzaffer",
                                                LastName="Bulut", Id=1, TcNo="4546546"});

            
        }
    }
}
