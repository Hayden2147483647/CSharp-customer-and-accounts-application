using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    internal class Controller
    {
        Customer customer;
        public List<Customer> allCustomers = new List<Customer>();

        public void addCustomer(int id, string name)
        {
            allCustomers.Add(new Customer(id, name));
        }

        public void removeCustomer(int id)
        {
            if (customer.getId() == id)
            {
                allCustomers.Remove(customer);
            }
            else
            {
                throw new Exception();
            }
        }

        public void editCustomer(Customer cust)
        {
            cust.setId(customer.getId());
            cust.setName(customer.getName());
            allCustomers.Append(cust);
        }
    }
}
