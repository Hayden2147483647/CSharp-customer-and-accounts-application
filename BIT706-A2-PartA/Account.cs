using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_Assignment_1_5062155
{
    public class Account
    {
        protected int account_id;
        protected double balance_amount;
        protected string accountName = "Everyday";

        public Account(int account_id, double balance_amount)
        {
            this.account_id = account_id;
            this.balance_amount = balance_amount;
        }

        public int getAccountID()
        {
            return account_id;
        }

        public double getBalance()
        {
            return balance_amount;
        }

        public void setBalance(double balance)
        {
            balance_amount = balance;
        }

        public String getAccountName()
        {
            return accountName;
        }

        public String getBalanceString()
        {
            return "$" + getBalance().ToString();
        }

        public virtual String getAccountInfo()
        {
            return "Everyday " + getAccountID().ToString() + "; " + "Balance " + getBalance().ToString();
        }
    }
}
