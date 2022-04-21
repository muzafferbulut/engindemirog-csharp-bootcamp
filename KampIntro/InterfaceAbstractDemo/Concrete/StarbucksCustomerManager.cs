using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : CustomerManager
    {
        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
