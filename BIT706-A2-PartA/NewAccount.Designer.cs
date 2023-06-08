namespace BIT706_A2_PartA
{
    partial class NewAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newOmniRadioButton = new System.Windows.Forms.RadioButton();
            this.newInvestmentRadioButton = new System.Windows.Forms.RadioButton();
            this.newEverydayRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewAccountbutton = new System.Windows.Forms.Button();
            this.backFromNewAccountButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newOmniRadioButton);
            this.groupBox1.Controls.Add(this.newInvestmentRadioButton);
            this.groupBox1.Controls.Add(this.newEverydayRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(91, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account type";
            // 
            // newOmniRadioButton
            // 
            this.newOmniRadioButton.AutoSize = true;
            this.newOmniRadioButton.Location = new System.Drawing.Point(216, 29);
            this.newOmniRadioButton.Name = "newOmniRadioButton";
            this.newOmniRadioButton.Size = new System.Drawing.Size(49, 17);
            this.newOmniRadioButton.TabIndex = 2;
            this.newOmniRadioButton.TabStop = true;
            this.newOmniRadioButton.Text = "Omni";
            this.newOmniRadioButton.UseVisualStyleBackColor = true;
            // 
            // newInvestmentRadioButton
            // 
            this.newInvestmentRadioButton.AutoSize = true;
            this.newInvestmentRadioButton.Location = new System.Drawing.Point(108, 29);
            this.newInvestmentRadioButton.Name = "newInvestmentRadioButton";
            this.newInvestmentRadioButton.Size = new System.Drawing.Size(77, 17);
            this.newInvestmentRadioButton.TabIndex = 1;
            this.newInvestmentRadioButton.TabStop = true;
            this.newInvestmentRadioButton.Text = "Investment";
            this.newInvestmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // newEverydayRadioButton
            // 
            this.newEverydayRadioButton.AutoSize = true;
            this.newEverydayRadioButton.Location = new System.Drawing.Point(17, 29);
            this.newEverydayRadioButton.Name = "newEverydayRadioButton";
            this.newEverydayRadioButton.Size = new System.Drawing.Size(69, 17);
            this.newEverydayRadioButton.TabIndex = 0;
            this.newEverydayRadioButton.TabStop = true;
            this.newEverydayRadioButton.Text = "Everyday";
            this.newEverydayRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "MyBank";
            // 
            // addNewAccountbutton
            // 
            this.addNewAccountbutton.Location = new System.Drawing.Point(262, 175);
            this.addNewAccountbutton.Name = "addNewAccountbutton";
            this.addNewAccountbutton.Size = new System.Drawing.Size(112, 60);
            this.addNewAccountbutton.TabIndex = 4;
            this.addNewAccountbutton.Text = "Add New Account";
            this.addNewAccountbutton.UseVisualStyleBackColor = true;
            this.addNewAccountbutton.Click += new System.EventHandler(this.addNewAccountbutton_Click);
            // 
            // backFromNewAccountButton
            // 
            this.backFromNewAccountButton.Location = new System.Drawing.Point(91, 175);
            this.backFromNewAccountButton.Name = "backFromNewAccountButton";
            this.backFromNewAccountButton.Size = new System.Drawing.Size(112, 60);
            this.backFromNewAccountButton.TabIndex = 5;
            this.backFromNewAccountButton.Text = "Back";
            this.backFromNewAccountButton.UseVisualStyleBackColor = true;
            this.backFromNewAccountButton.Click += new System.EventHandler(this.backFromNewAccountButton_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(437, 277);
            this.Controls.Add(this.backFromNewAccountButton);
            this.Controls.Add(this.addNewAccountbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAccount";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton newOmniRadioButton;
        private System.Windows.Forms.RadioButton newInvestmentRadioButton;
        private System.Windows.Forms.RadioButton newEverydayRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewAccountbutton;
        private System.Windows.Forms.Button backFromNewAccountButton;
    }
}