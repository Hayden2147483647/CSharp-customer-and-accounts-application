using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assignment_1_5062155
{
    public class Invest : Account
    {
        protected double intrest;
        protected double fees;
        protected string investName = "Investment";

        public Invest(int account_id, double balance_amount) : base(account_id, balance_amount)
        { 

        }

        public double Interest
        {
            get { return intrest; } 
            set {  intrest = value; } 
        }

        public double Fees
        {
            get { return fees; } 
            set {  fees = value; } 
        }

        public String calculateIntrest()
        {

            return intrest.ToString() + "%";
        }

        public String calculateFees()
        {
            return "$" + fees.ToString();
        }

        public override String getAccountInfo()
        {
            return "Investment " + getAccountID().ToString() + ";\n" + "Interest Rate " + calculateIntrest() + ";\n" + "Fee " + calculateFees() + ";\n" + "Balance " + getBalanceString();
        }
    }
}
