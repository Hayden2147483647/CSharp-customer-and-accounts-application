using BIT706_Assignment_1_5062155;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    [Serializable()]
    public class Staff : Customer
    {
        protected int id;
        protected string name;
        protected List<Account> accounts = new List<Account>();
        protected bool isStaff = true;

        public Staff(int id, string name, bool isStaff) : base (id, name, isStaff)
        {

        }
    }
}
