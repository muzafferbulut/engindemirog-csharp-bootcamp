using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        // bu sınıf operasyon sınıfı olarak kullanılacak. Müşterilerle ilgili operasyonlar bu sınıfta yer alacak
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added: "+customer.FirstName+" "+customer.LastName);
        }

        public void DelCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.Id);
        }

        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("Customers listed.");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.FirstName + " "+ customer.LastName);
            }
        }
    }
}
