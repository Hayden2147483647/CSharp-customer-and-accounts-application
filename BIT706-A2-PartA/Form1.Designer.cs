namespace BIT706_A2_PartA
{
    partial class Main
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
            this.testAllUserslistBox = new System.Windows.Forms.ListBox();
            this.testIDInput = new System.Windows.Forms.TextBox();
            this.testName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testAddCustomerButton = new System.Windows.Forms.Button();
            this.testEditCustomerButton = new System.Windows.Forms.Button();
            this.testDeleteCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testAllUserslistBox
            // 
            this.testAllUserslistBox.FormattingEnabled = true;
            this.testAllUserslistBox.ItemHeight = 20;
            this.testAllUserslistBox.Location = new System.Drawing.Point(99, 93);
            this.testAllUserslistBox.Name = "testAllUserslistBox";
            this.testAllUserslistBox.Size = new System.Drawing.Size(191, 444);
            this.testAllUserslistBox.TabIndex = 0;
            // 
            // testIDInput
            // 
            this.testIDInput.Location = new System.Drawing.Point(537, 93);
            this.testIDInput.Name = "testIDInput";
            this.testIDInput.Size = new System.Drawing.Size(100, 26);
            this.testIDInput.TabIndex = 1;
            // 
            // testName
            // 
            this.testName.Location = new System.Drawing.Point(760, 93);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(209, 26);
            this.testName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // testAddCustomerButton
            // 
            this.testAddCustomerButton.Location = new System.Drawing.Point(426, 205);
            this.testAddCustomerButton.Name = "testAddCustomerButton";
            this.testAddCustomerButton.Size = new System.Drawing.Size(164, 71);
            this.testAddCustomerButton.TabIndex = 5;
            this.testAddCustomerButton.Text = "Add Customer";
            this.testAddCustomerButton.UseVisualStyleBackColor = true;
            this.testAddCustomerButton.Click += new System.EventHandler(this.testAddCustomerButton_Click);
            // 
            // testEditCustomerButton
            // 
            this.testEditCustomerButton.Location = new System.Drawing.Point(651, 205);
            this.testEditCustomerButton.Name = "testEditCustomerButton";
            this.testEditCustomerButton.Size = new System.Drawing.Size(164, 71);
            this.testEditCustomerButton.TabIndex = 6;
            this.testEditCustomerButton.Text = "Edit Customer";
            this.testEditCustomerButton.UseVisualStyleBackColor = true;
            this.testEditCustomerButton.Click += new System.EventHandler(this.testEditCustomerButton_Click);
            // 
            // testDeleteCustomerButton
            // 
            this.testDeleteCustomerButton.Location = new System.Drawing.Point(873, 205);
            this.testDeleteCustomerButton.Name = "testDeleteCustomerButton";
            this.testDeleteCustomerButton.Size = new System.Drawing.Size(164, 71);
            this.testDeleteCustomerButton.TabIndex = 7;
            this.testDeleteCustomerButton.Text = "Delete Customer";
            this.testDeleteCustomerButton.UseVisualStyleBackColor = true;
            this.testDeleteCustomerButton.Click += new System.EventHandler(this.testDeleteCustomerButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.testDeleteCustomerButton);
            this.Controls.Add(this.testEditCustomerButton);
            this.Controls.Add(this.testAddCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testName);
            this.Controls.Add(this.testIDInput);
            this.Controls.Add(this.testAllUserslistBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Bank E.G.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testAllUserslistBox;
        private System.Windows.Forms.TextBox testIDInput;
        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testAddCustomerButton;
        private System.Windows.Forms.Button testEditCustomerButton;
        private System.Windows.Forms.Button testDeleteCustomerButton;
    }
}

