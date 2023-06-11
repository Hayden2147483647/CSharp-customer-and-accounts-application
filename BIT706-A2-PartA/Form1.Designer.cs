namespace BIT706_A2_PartA
{
    partial class AllCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allCustomerslistBox = new System.Windows.Forms.ListBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testAddCustomerButton = new System.Windows.Forms.Button();
            this.testEditCustomerButton = new System.Windows.Forms.Button();
            this.testDeleteCustomerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.manageAccountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allCustomerslistBox
            // 
            this.allCustomerslistBox.FormattingEnabled = true;
            this.allCustomerslistBox.Location = new System.Drawing.Point(66, 73);
            this.allCustomerslistBox.Margin = new System.Windows.Forms.Padding(2);
            this.allCustomerslistBox.Name = "allCustomerslistBox";
            this.allCustomerslistBox.Size = new System.Drawing.Size(212, 290);
            this.allCustomerslistBox.TabIndex = 0;
            this.allCustomerslistBox.SelectedIndexChanged += new System.EventHandler(this.testAllUserslistBox_SelectedIndexChanged);
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(316, 73);
            this.idInput.Margin = new System.Windows.Forms.Padding(2);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(68, 20);
            this.idInput.TabIndex = 1;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(415, 73);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(141, 20);
            this.nameInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // testAddCustomerButton
            // 
            this.testAddCustomerButton.Location = new System.Drawing.Point(316, 132);
            this.testAddCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.testAddCustomerButton.Name = "testAddCustomerButton";
            this.testAddCustomerButton.Size = new System.Drawing.Size(109, 46);
            this.testAddCustomerButton.TabIndex = 5;
            this.testAddCustomerButton.Text = "Add Customer";
            this.testAddCustomerButton.UseVisualStyleBackColor = true;
            this.testAddCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // testEditCustomerButton
            // 
            this.testEditCustomerButton.Location = new System.Drawing.Point(316, 192);
            this.testEditCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.testEditCustomerButton.Name = "testEditCustomerButton";
            this.testEditCustomerButton.Size = new System.Drawing.Size(109, 46);
            this.testEditCustomerButton.TabIndex = 6;
            this.testEditCustomerButton.Text = "Edit Selected Customer";
            this.testEditCustomerButton.UseVisualStyleBackColor = true;
            this.testEditCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // testDeleteCustomerButton
            // 
            this.testDeleteCustomerButton.Location = new System.Drawing.Point(316, 254);
            this.testDeleteCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.testDeleteCustomerButton.Name = "testDeleteCustomerButton";
            this.testDeleteCustomerButton.Size = new System.Drawing.Size(109, 46);
            this.testDeleteCustomerButton.TabIndex = 7;
            this.testDeleteCustomerButton.Text = "Delete Selected Customer";
            this.testDeleteCustomerButton.UseVisualStyleBackColor = true;
            this.testDeleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "MyBank";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(546, 373);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(95, 40);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // manageAccountsButton
            // 
            this.manageAccountsButton.Location = new System.Drawing.Point(316, 317);
            this.manageAccountsButton.Name = "manageAccountsButton";
            this.manageAccountsButton.Size = new System.Drawing.Size(109, 46);
            this.manageAccountsButton.TabIndex = 10;
            this.manageAccountsButton.Text = "Manage selected Customer Accounts";
            this.manageAccountsButton.UseVisualStyleBackColor = true;
            this.manageAccountsButton.Click += new System.EventHandler(this.manageAccountsButton_Click);
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(653, 425);
            this.Controls.Add(this.manageAccountsButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testDeleteCustomerButton);
            this.Controls.Add(this.testEditCustomerButton);
            this.Controls.Add(this.testAddCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.allCustomerslistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AllCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allCustomerslistBox;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testAddCustomerButton;
        private System.Windows.Forms.Button testEditCustomerButton;
        private System.Windows.Forms.Button testDeleteCustomerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button manageAccountsButton;
    }
}

