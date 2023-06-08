using BIT706_A2_PartA;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_Assignment_1_5062155
{
    public partial class AllAccounts : Form
    {
        private Label label1;
        public  Label customerInfoLabel;
        private Button newAccountButton;
        private Button depositButton;
        private Button withdrawButton;
        private Button transferButton;
        public ListBox allAccountslistBox;
        private Button backToAllCustomersButton;
        private TextBox depositWithdrawTextBox;
        private Label label2;
        private static Controller controller = new Controller();
        private double doubleCheck;

        public AllAccounts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void editAccount(Customer customer, Account acc)
        {
            customer.customerAccountsList.Append(acc);
        }


        private void InitializeComponent()
        {
            this.allAccountslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.backToAllCustomersButton = new System.Windows.Forms.Button();
            this.depositWithdrawTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allAccountslistBox
            // 
            this.allAccountslistBox.FormattingEnabled = true;
            this.allAccountslistBox.Location = new System.Drawing.Point(12, 121);
            this.allAccountslistBox.Name = "allAccountslistBox";
            this.allAccountslistBox.Size = new System.Drawing.Size(254, 225);
            this.allAccountslistBox.TabIndex = 0;
            this.allAccountslistBox.SelectedIndexChanged += new System.EventHandler(this.allAccountslistBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyBank";
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLabel.Location = new System.Drawing.Point(13, 58);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(70, 25);
            this.customerInfoLabel.TabIndex = 3;
            this.customerInfoLabel.Text = "label2";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(272, 121);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(104, 50);
            this.newAccountButton.TabIndex = 4;
            this.newAccountButton.Text = "Add New Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(272, 178);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(104, 51);
            this.depositButton.TabIndex = 5;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(272, 236);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(104, 50);
            this.withdrawButton.TabIndex = 6;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(272, 293);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(104, 53);
            this.transferButton.TabIndex = 7;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // backToAllCustomersButton
            // 
            this.backToAllCustomersButton.Location = new System.Drawing.Point(12, 352);
            this.backToAllCustomersButton.Name = "backToAllCustomersButton";
            this.backToAllCustomersButton.Size = new System.Drawing.Size(104, 53);
            this.backToAllCustomersButton.TabIndex = 8;
            this.backToAllCustomersButton.Text = "Back";
            this.backToAllCustomersButton.UseVisualStyleBackColor = true;
            this.backToAllCustomersButton.Click += new System.EventHandler(this.backToAllCustomersButton_Click);
            // 
            // depositWithdrawTextBox
            // 
            this.depositWithdrawTextBox.Location = new System.Drawing.Point(417, 220);
            this.depositWithdrawTextBox.Name = "depositWithdrawTextBox";
            this.depositWithdrawTextBox.Size = new System.Drawing.Size(164, 20);
            this.depositWithdrawTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deposit/Withdraw";
            // 
            // AllAccounts
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(625, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositWithdrawTextBox);
            this.Controls.Add(this.backToAllCustomersButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.customerInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allAccountslistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Accounts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void allAccountslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            controller.newAccountGUI();
        }

        private void backToAllCustomersButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            controller.allCustomerGUI();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (depositWithdrawTextBox.Text.Equals("") || depositWithdrawTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please put in an amount first to\ndeposit or withdraw from the selected balance");
            }
            else if (allAccountslistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Account before you deposit");
            }
            else if (!double.TryParse(depositWithdrawTextBox.Text, out doubleCheck))
            {
                MessageBox.Show("Please input a valid number");
            }
            else if (double.Parse(depositWithdrawTextBox.Text) <= 0)
            {
                MessageBox.Show("Please input a positive number");
            }
            else
            {
                controller.editAccountBalance(AllCustomers.selectedCustomer, AllCustomers.selectedCustomer.customerAccountsList[allAccountslistBox.SelectedIndex], double.Parse(depositWithdrawTextBox.Text));
                allAccountslistBox.Items[allAccountslistBox.SelectedIndex] = controller.accountString(AllCustomers.selectedCustomer.customerAccountsList[allAccountslistBox.SelectedIndex]);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

        }
    }
}
