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
        private Controller control = new Controller();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testAddCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                control.addCustomer(int.Parse(testIDInput.Text), testName.Text.ToString());
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Didn't work");
            }
            //Updates and displays all customers in the list to the list box
            testAllUserslistBox.Text = control.allCustomers.ToString(); 
        }

        private void testDeleteCustomerButton_Click(object sender, EventArgs e)
        {
            Customer cust;
            cust = testAllUserslistBox.SelectedItem as Customer;
            //Don't know if this will work or not
            //TODO: Test to see
            control.removeCustomer(cust);
            //Updates and displays all customers in the list to the list box
            testAllUserslistBox.Text = control.allCustomers.ToString();
        }

        private void testEditCustomerButton_Click(object sender, EventArgs e)
        {
            Customer cust;
            cust = testAllUserslistBox.SelectedItem as Customer;
            //TODO: Also need to test the edit
            control.editCustomer(cust, int.Parse(testIDInput.Text.ToString()), testName.Text.ToString());
            //Updates and displays all customers in the list to the list box
            testAllUserslistBox.Text = control.allCustomers.ToString();
        }
    }
}
