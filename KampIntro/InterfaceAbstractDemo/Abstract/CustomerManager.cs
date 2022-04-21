using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class CustomerManager : ICustomerService
    {
        // base görevi görecek
        public void Save(Customer customer)
        {
            Console.WriteLine("Veri tabanına kayıt işlemi başarıyla gerçekleşti.");
        }

        internal void Save(object p, object )
        {
            throw new NotImplementedException();
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
