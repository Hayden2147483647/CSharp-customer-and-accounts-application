using BIT706_Assignment_1_5062155;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_PartA
{
    public class Controller
    {
        public static AllCustomers allCustomers = new AllCustomers();
        public static AllAccounts allAccounts = new AllAccounts();
        public static NewAccount newAccount = new NewAccount();
        private int id = 0;

        public Customer addCustomer(int id, string name)
        {
            Customer customer;
            customer = new Customer(id, name);
            allCustomers.addCustomer(customer);
            return customer;
        }

        public void removeCustomer(Customer cust)
        {
            allCustomers.removeCustomer(cust);
        }

        public Customer editCustomer(Customer cust, int id, string name)
        {
            cust.setId(id);
            cust.setName(name);
            allCustomers.updateCustomer(cust);
            return cust;
        }

        public Account addAccount(double amount)
        {
            Account account = new Account(this.id++, amount);
            return account;
        }

        public void editAccountBalance(Customer cust, Account acc, double balance)
        {
            acc.setBalance(balance);
            allAccounts.editAccount(cust, acc);
        }

        public Invest addInvest(double amount) 
        {
            Invest invest = new Invest(this.id++, 0.00);
            invest.Interest = 4; 
            invest.Fees = 0;
            return invest;
        }

        public Omni addOmni(double amount)
        {
            Omni omni = new Omni(this.id++, 0.00);
            omni.Interest = 4;
            omni.Fees = 0;
            omni.Overdraft = 0;
            return omni;
        }

        public string customerString(Customer cust)
        {
            return cust.getId().ToString() + "\t" + cust.getName();
        }

        public string accountString(Account account)
        {
            return account.getAccountName() + "\t" + account.getBalanceString();
        }

        public AllAccounts getAllAccount()
        {
            return allAccounts;
        }

        public void allCustomerGUI()
        {
            allCustomers.Visible = true;
        }

        public void allAccountsGUI()
        {
            allAccounts.Visible = true;
        }

        public void newAccountGUI()
        {
            newAccount.Visible = true;
        }
    }
}
