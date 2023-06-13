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
        public static Main_form mainForm = new Main_form();
        public static AllCustomers allCustomers = new AllCustomers();
        public static AllAccounts allAccounts = new AllAccounts();
        public static NewAccount newAccount = new NewAccount();
        public static Transfer transfer = new Transfer();
        public static Serialize serialize = new Serialize();
        private int accID = 0;
        public int custID = 1;

        public Customer addCustomer(string name)
        {
            Customer customer;
            customer = new Customer(this.custID++, name, false);
            allCustomers.addCustomer(customer);
            return customer;
        }

        public void removeCustomer(Customer cust)
        {
            allCustomers.removeCustomer(cust);
        }

        public Customer editCustomer(Customer cust, string name)
        {
            cust.setName(name);
            allCustomers.updateCustomer(cust);
            return cust;
        }

        public Account addAccount(double amount)
        {
            Account account = new Account(this.accID++, amount);
            return account;
        }

        public void editAccountBalance(Customer cust, Account acc, double balance)
        {
            acc.setBalance(acc.getBalance() + balance);
            allAccounts.editAccount(cust, acc);
        }

        public Invest addInvest(double amount) 
        {
            Invest invest = new Invest(this.accID++, 0.00);
            invest.Interest = 4; 
            invest.Fees = 0;
            return invest;
        }

        public Omni addOmni(double amount)
        {
            Omni omni = new Omni(this.accID++, 0.00);
            omni.Interest = 4;
            omni.Fees = 0;
            omni.Overdraft = 0;
            return omni;
        }

        public string customerString(Customer cust)
        {
            return cust.getId().ToString() + "\t" + cust.getName();
        }

        public string accountString(List<Account> account, int element)
        {
            return account.ElementAt(element).getAccountName() + "\t" + account.ElementAt(element).getAccountID() + "\t" + account.ElementAt(element).getBalanceString() + "\t" + account.ElementAt(element).getInterest() + "%";
        }

        public AllAccounts getAllAccount()
        {
            return allAccounts;
        }

        public Transfer getTransfer()
        {
            return transfer; 
        }

        public AllCustomers getAllCustomers()
        {
            return allCustomers;
        }

        public Serialize getSerializer()
        {
            return serialize;
        }

        public void allCustomerGUI()
        {
            allCustomers.Show();
        }

        public void allAccountsGUI()
        {
            allAccounts.Show();
        }

        public void newAccountGUI()
        {
            newAccount.Show();
        }

        public void transferGUI()
        {
            transfer.Show();
        }
        public void mainFormGUI()
        {
            mainForm.Show();
        }
        public void onClose()
        {
            serialize.serializing();
            Environment.Exit(0);
        }
    }
}
