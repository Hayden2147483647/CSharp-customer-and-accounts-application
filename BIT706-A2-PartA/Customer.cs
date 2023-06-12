using BIT706_Assignment_1_5062155;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    [Serializable()]
    public class Customer
    {
        private int id;
        private string name;
        private List<Account> accounts = new List<Account>();
        private bool isStaff = false;

        public Customer(int id, string name, bool isStaff)
        {
            this.id = id;
            this.name = name;
            this.isStaff = isStaff;
        }

        public List<Account> customerAccountsList
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public int getId()
        {
            return id;
        }

        public string getName() 
        { 
            return name;
        }

        public bool isCustomerStaff()
        {
            return isStaff;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getInfo()
        {
            return id.ToString() + " \t " + name;
        }
    }
}
