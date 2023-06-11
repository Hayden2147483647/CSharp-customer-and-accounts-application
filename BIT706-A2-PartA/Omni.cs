using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assignment_1_5062155
{
    public class Omni : Account
    {
       protected double interest;
       protected double overdraft;
       protected double fees;
       protected string omniName = "Omni";

        public Omni(int account_id, double balance_amount) : base(account_id, balance_amount)
        {

        }

        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        public double Overdraft
        {
            get { return overdraft; }
            set { overdraft = value; }
        }

        public String calculateIntrest()
        {

            return interest.ToString() + "%";
        }

        public override double getInterest()
        {
            return interest;
        }

        public override void setInterest(double interestSet) => this.Interest = interestSet;

        public String getOverdraft()
        {
            return "$" + overdraft.ToString();
        }

        public String calculateFees()
        {
            return "$" + fees.ToString();
        }

        public override String getAccountName()
        {
            return omniName;
        }


        public override String getAccountInfo()
        {
            return omniName + " " + getAccountID().ToString() + ";\n" + "Interest " + calculateIntrest() + ";Balance $" + getBalanceString();
        }
    }
}
