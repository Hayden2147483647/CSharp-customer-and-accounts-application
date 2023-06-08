using BIT706_Assignment_1_5062155;
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
    public partial class NewAccount : Form
    {
        private static Controller controller = new Controller();
        public NewAccount()
        {
            InitializeComponent();
            newEverydayRadioButton.Checked = true;
        }

        private void backFromNewAccountButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            controller.allAccountsGUI();
        }

        private void addNewAccountbutton_Click(object sender, EventArgs e)
        {
            if (newEverydayRadioButton.Checked == true)
            {
                Account newEveryday = controller.addAccount(0.00);
                AllCustomers.selectedCustomer.customerAccountsList.Add(newEveryday);
                controller.getAllAccount().allAccountslistBox.Items.Add(newEveryday.getAccountInfo());
            }
            else if (newInvestmentRadioButton.Checked == true)
            {
                Invest newInvest = controller.addInvest(0.00);
                AllCustomers.selectedCustomer.customerAccountsList.Add(newInvest);
                controller.getAllAccount().allAccountslistBox.Items.Add(newInvest.getAccountInfo());
            }
            else
            {
                Omni newOmni = controller.addOmni(0.00);
                AllCustomers.selectedCustomer.customerAccountsList.Add(newOmni);
                controller.getAllAccount().allAccountslistBox.Items.Add(newOmni.getAccountInfo());
            }
            this.Visible = false;
            controller.allAccountsGUI();
        }
    }
}
