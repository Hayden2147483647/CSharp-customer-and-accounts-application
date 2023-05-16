using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A2_PartA
{
    public partial class Main : Form
    {
        static Controller control = new Controller();
        static int intCheck;
        private bool editButtonClicked = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            editButtonClicked = false;
            try
            {
                if (idInput.Text.Length == 0 || nameInput.Text.Length == 0)
                {
                    MessageBox.Show("Please make sure both inputs are not blank");
                }
                else if (!int.TryParse(idInput.Text, out intCheck))
                {
                    MessageBox.Show("Please input a whole number into the ID input");
                }
                else
                {
                    Customer customerInput = control.addCustomer(int.Parse(idInput.Text), nameInput.Text.ToString());
                    allCustomerslistBox.Items.Add(control.customerString(customerInput));
                    idInput.Text = "";
                    nameInput.Text = "";
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Didn't work");
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            Customer cust;
            cust = control.allCustomers[allCustomerslistBox.SelectedIndex];
            control.removeCustomer(cust);
            //Updates and displays all customers in the list to the list box
            allCustomerslistBox.Items.Remove(control.customerString(cust));
            editButtonClicked = false;
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            Customer cust;
            cust = control.allCustomers[allCustomerslistBox.SelectedIndex];
            if (idInput.Text.Length == 0 || nameInput.Text.Length == 0)
            {
                MessageBox.Show("Please make sure both inputs are not blank");
            }
            else if (!int.TryParse(idInput.Text, out intCheck))
            {
                MessageBox.Show("Please input a whole number into the ID input");
            }
            else
            {
                control.editCustomer(cust, int.Parse(idInput.Text.ToString()), nameInput.Text.ToString());
                editButtonClicked = true;
                //Updates and displays all customers in the list to the list box
                allCustomerslistBox.Items[allCustomerslistBox.SelectedIndex] = control.customerString(cust);
            }
            editButtonClicked = false;
        }

        private void testAllUserslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer custom;
            //throw exception here for selected index is out of range, since it was deleted
            if (allCustomerslistBox.SelectedIndex == -1)
            {
                if (editButtonClicked == true)
                {
                    MessageBox.Show("Customer Edited Successfully");
                }
                else
                {
                    MessageBox.Show("Customer Deleted");
                    idInput.Text = "";
                    nameInput.Text = "";
                }
            }
            else
            {
                custom = control.allCustomers[allCustomerslistBox.SelectedIndex];
                idInput.Text = custom.getId().ToString();
                nameInput.Text = custom.getName();
            }
        }
    }
}
