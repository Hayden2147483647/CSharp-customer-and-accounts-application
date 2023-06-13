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
    /// <summary>
    /// Controller class that handles alot of the actions
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Main form class object
        /// </summary>
        public static Main_form mainForm = new Main_form();
        /// <summary>
        /// allcustomers class object
        /// </summary>
        public static AllCustomers allCustomers = new AllCustomers();
        /// <summary>
        /// allaccounts class object
        /// </summary>
        public static AllAccounts allAccounts = new AllAccounts();
        /// <summary>
        /// newAccount class object
        /// </summary>
        public static NewAccount newAccount = new NewAccount();
        /// <summary>
        /// transfer class object
        /// </summary>
        public static Transfer transfer = new Transfer();
        /// <summary>
        /// serialize class object
        /// </summary>
        public static Serialize serialize = new Serialize();
        /// <summary>
        /// account id for every new account made (ID will be ++ down below)
        /// </summary>
        private int accID = 0;
        /// <summary>
        /// Customer id for every new customer made (ID will be ++ down below)
        /// </summary>
        public int custID = 1;

        /// <summary>
        /// This method adds a new customer object to the Customer class as well as adds the customer to the allCustomers list
        /// </summary>
        /// <param name="name">The name for the new customer</param>
        /// <returns>Returns the newly added customer</returns>
        public Customer addCustomer(string name)
        {
            Customer customer;
            if (name.Equals("Hayden") || name.Equals("Sandra"))
            {
                customer = new Customer(this.custID++, name, true);
            }
            else
            {
                customer = new Customer(this.custID++, name, false);
            }
            allCustomers.addCustomer(customer);
            return customer;
        }
        /// <summary>
        /// This method removes the input customer from the Customer class and the allCustomer list
        /// </summary>
        /// <param name="cust">The customer to remove</param>
        public void removeCustomer(Customer cust)
        {
            allCustomers.removeCustomer(cust);
        }
        /// <summary>
        /// This method edits the input customer objects name to the input string
        /// </summary>
        /// <param name="cust">The customer to edit</param>
        /// <param name="name">The new name for the customer</param>
        /// <returns>The edited customer</returns>
        public Customer editCustomer(Customer cust, string name)
        {
            cust.setName(name);
            allCustomers.updateCustomer(cust);
            return cust;
        }
        /// <summary>
        /// This method adds a new account to the Account class
        /// </summary>
        /// <param name="amount">The balance for the new account</param>
        /// <returns>The new account</returns>
        public Account addAccount(double amount)
        {
            Account account = new Account(this.accID++, amount);
            return account;
        }
        /// <summary>
        /// This method edits a customers account balance, mostly used for deposits and withdraws
        /// </summary>
        /// <param name="cust">The customer of which account to edit</param>
        /// <param name="acc">The account to edit</param>
        /// <param name="balance">The amount to set the balance for</param>
        public void editAccountBalance(Customer cust, Account acc, double balance)
        {
            acc.setBalance(acc.getBalance() + balance);
            allAccounts.editAccount(cust, acc);
        }
        /// <summary>
        /// This method adds a new Investment account to the Account class
        /// </summary>
        /// <param name="amount">The balance amount</param>
        /// <returns>The Investment account</returns>
        public Invest addInvest(double amount) 
        {
            Invest invest = new Invest(this.accID++, 0.00);
            invest.Interest = 4; 
            invest.Fees = 10;
            return invest;
        }
        /// <summary>
        /// This method adds a new Omni account to the Account class
        /// </summary>
        /// <param name="amount">The balance amount</param>
        /// <returns>The Omni account</returns>
        public Omni addOmni(double amount)
        {
            Omni omni = new Omni(this.accID++, 0.00);
            omni.Interest = 4;
            omni.Fees = 10;
            omni.Overdraft = 0;
            return omni;
        }
        /// <summary>
        /// This method returns the customers full info
        /// </summary>
        /// <param name="cust">The customer to get the info from</param>
        /// <returns>The customers id and name</returns>
        public string customerString(Customer cust)
        {
            return cust.getId().ToString() + "\t" + cust.getName();
        }
        /// <summary>
        /// This method returns the accounts full info
        /// </summary>
        /// <param name="account">The account to get the info from</param>
        /// <param name="element">The exact index to get the exact account</param>
        /// <returns>The accounts name, id, balance, and interest</returns>
        public string accountString(List<Account> account, int element)
        {
            return account.ElementAt(element).getAccountName() + "\t" + account.ElementAt(element).getAccountID() + "\t" + account.ElementAt(element).getBalanceString() + "\t" + account.ElementAt(element).getInterest() + "%";
        }
        /// <summary>
        /// This method gets the AllAccount class object
        /// </summary>
        /// <returns>AllAccount object</returns>
        public AllAccounts getAllAccount()
        {
            return allAccounts;
        }
        /// <summary>
        /// This method gets the Transfer class object
        /// </summary>
        /// <returns>Transfer object</returns>
        public Transfer getTransfer()
        {
            return transfer; 
        }
        /// <summary>
        /// This method gets the AllCustomer class object
        /// </summary>
        /// <returns>AllCustomer object</returns>
        public AllCustomers getAllCustomers()
        {
            return allCustomers;
        }
        /// <summary>
        /// This method gets the Serialize class object
        /// </summary>
        /// <returns>Serialize object</returns>
        public Serialize getSerializer()
        {
            return serialize;
        }
        /// <summary>
        /// This method shows the allCustomers screen
        /// </summary>
        public void allCustomerGUI()
        {
            allCustomers.Show();
        }
        /// <summary>
        /// This method shows the allAccounts screen
        /// </summary>
        public void allAccountsGUI()
        {
            allAccounts.Show();
        }
        /// <summary>
        /// This method shows the newAccount screen
        /// </summary>
        public void newAccountGUI()
        {
            newAccount.Show();
        }
        /// <summary>
        /// This method shows the transfer screen
        /// </summary>
        public void transferGUI()
        {
            transfer.Show();
        }
        /// <summary>
        /// This method shows the main form screen
        /// </summary>
        public void mainFormGUI()
        {
            mainForm.Show();
        }
        /// <summary>
        /// This method serializes all the customer infomation and closes the application
        /// </summary>
        public void onClose()
        {
            serialize.serializing();
            Environment.Exit(0);
        }
    }
}
