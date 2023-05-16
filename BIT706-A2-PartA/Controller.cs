using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    internal class Controller
    {
        public List<Customer> allCustomers = new List<Customer>();
        public String allCustomerString;

        public Customer addCustomer(int id, string name)
        {
            Customer customer;
            customer = new Customer(id, name);
            allCustomers.Add(customer);
            return customer;
        }

        public void removeCustomer(Customer cust)
        {
            allCustomers.Remove(cust);
        }

        public Customer editCustomer(Customer cust, int id, string name)
        {
            cust.setId(id);
            cust.setName(name);
            allCustomers.Append(cust);
            return cust;
        }

        public string customerString(Customer cust)
        {
            return cust.getId().ToString() + "\t" + cust.getName();
        }
    }
}
