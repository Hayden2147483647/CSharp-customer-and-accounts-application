using BIT706_Assignment_1_5062155;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    public class Customer
    {
        private int id;
        private string name;
        private List<Account> accounts = new List<Account>();

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
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
