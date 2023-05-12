using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    internal class Controller
    {

        public List<Customer> allCustomers = new List<Customer>();

        public void addCustomer(int id, string name)
        {
            allCustomers.Add(new Customer(id, name));
        }

        public void removeCustomer(Customer cust)
        {
            allCustomers.Remove(cust);
        }

        public void editCustomer(Customer cust, int id, string name)
        {
            cust.setId(id);
            cust.setName(name);
            allCustomers.Append(cust);
        }
    }
}
