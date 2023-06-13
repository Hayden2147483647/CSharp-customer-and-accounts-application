using System;
using System.Collections;
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
    public partial class Transfer : Form
    {
        protected double doubleCheck;
        private static Controller controller = new Controller();
        public Transfer()
        {
            InitializeComponent();
        }

        private void backFromTransferButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            transferToListBox.Items.Clear();
            transferFromListBox.Items.Clear();
            controller.getAllAccount().allAccountslistBox.Items.Clear();
            controller.allAccountsGUI();
            for (int i = 0; i < AllCustomers.selectedCustomer.customerAccountsList.Count; i++)
            {
                controller.getAllAccount().allAccountslistBox.Items.Add(AllCustomers.selectedCustomer.customerAccountsList.ElementAt(i).getAccountInfo());
            }
        }

        private void confirmTransferButton_Click(object sender, EventArgs e)
        {
            if (transferAmountTextBox.Text.Equals("") || transferAmountTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please put in an amount first to\ntransfer to the other selected account");
            }
            else if (transferFromListBox.SelectedIndex == -1 || transferToListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Accounts before you transfer");
            }
            else if (transferFromListBox.SelectedIndex == transferToListBox.SelectedIndex)
            {
                MessageBox.Show("You cannot transfer to the same account.\nPlease select two different accounts");
            }
            else if (!double.TryParse(transferAmountTextBox.Text, out doubleCheck))
            {
                MessageBox.Show("Please input a valid number");
            }
            else if (double.Parse(transferAmountTextBox.Text) <= 0)
            {
                MessageBox.Show("Please input a positive number");
            }
            else
            {
                controller.editAccountBalance(AllCustomers.selectedCustomer, AllCustomers.selectedCustomer.customerAccountsList[transferFromListBox.SelectedIndex], -double.Parse(transferAmountTextBox.Text));
                transferFromListBox.Items[transferFromListBox.SelectedIndex] = controller.accountString(AllCustomers.selectedCustomer.customerAccountsList, transferFromListBox.SelectedIndex);
                transferToListBox.Items[transferFromListBox.SelectedIndex] = controller.accountString(AllCustomers.selectedCustomer.customerAccountsList, transferFromListBox.SelectedIndex);
                controller.editAccountBalance(AllCustomers.selectedCustomer, AllCustomers.selectedCustomer.customerAccountsList[transferToListBox.SelectedIndex], double.Parse(transferAmountTextBox.Text));
                transferToListBox.Items[transferToListBox.SelectedIndex] = controller.accountString(AllCustomers.selectedCustomer.customerAccountsList, transferToListBox.SelectedIndex);
                transferFromListBox.Items[transferToListBox.SelectedIndex] = controller.accountString(AllCustomers.selectedCustomer.customerAccountsList, transferToListBox.SelectedIndex);
            }
        }

        private void Transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.onClose();
        }
    }
}
