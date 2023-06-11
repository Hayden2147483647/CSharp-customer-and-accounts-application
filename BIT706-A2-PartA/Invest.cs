﻿using System;
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

        public override double getInterest()
        {
            return intrest;
        }

        public override void setInterest(double interestSet) => this.Interest = interestSet;

        public String calculateFees()
        {
            return "$" + fees.ToString();
        }

        public override String getAccountName()
        {
            return investName;
        }

        public override String getAccountInfo()
        {
            return investName + " " + getAccountID().ToString() + ";\n" + "Interest " + calculateIntrest() + ";Balance " + getBalanceString();
        }
    }
}
