namespace BIT706_A2_PartA
{
    partial class Transfer
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
            this.transferFromListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transferToListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transferAmountTextBox = new System.Windows.Forms.TextBox();
            this.confirmTransferButton = new System.Windows.Forms.Button();
            this.backFromTransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferFromListBox
            // 
            this.transferFromListBox.FormattingEnabled = true;
            this.transferFromListBox.Location = new System.Drawing.Point(16, 82);
            this.transferFromListBox.Name = "transferFromListBox";
            this.transferFromListBox.Size = new System.Drawing.Size(142, 303);
            this.transferFromListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "MyBank";
            // 
            // transferToListBox
            // 
            this.transferToListBox.FormattingEnabled = true;
            this.transferToListBox.Location = new System.Drawing.Point(319, 82);
            this.transferToListBox.Name = "transferToListBox";
            this.transferToListBox.Size = new System.Drawing.Size(142, 303);
            this.transferToListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "--->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount to transfer:";
            // 
            // transferAmountTextBox
            // 
            this.transferAmountTextBox.Location = new System.Drawing.Point(187, 202);
            this.transferAmountTextBox.Name = "transferAmountTextBox";
            this.transferAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.transferAmountTextBox.TabIndex = 8;
            // 
            // confirmTransferButton
            // 
            this.confirmTransferButton.Location = new System.Drawing.Point(187, 281);
            this.confirmTransferButton.Name = "confirmTransferButton";
            this.confirmTransferButton.Size = new System.Drawing.Size(100, 43);
            this.confirmTransferButton.TabIndex = 9;
            this.confirmTransferButton.Text = "Transfer";
            this.confirmTransferButton.UseVisualStyleBackColor = true;
            this.confirmTransferButton.Click += new System.EventHandler(this.confirmTransferButton_Click);
            // 
            // backFromTransferButton
            // 
            this.backFromTransferButton.Location = new System.Drawing.Point(187, 342);
            this.backFromTransferButton.Name = "backFromTransferButton";
            this.backFromTransferButton.Size = new System.Drawing.Size(100, 43);
            this.backFromTransferButton.TabIndex = 10;
            this.backFromTransferButton.Text = "Back";
            this.backFromTransferButton.UseVisualStyleBackColor = true;
            this.backFromTransferButton.Click += new System.EventHandler(this.backFromTransferButton_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(489, 407);
            this.Controls.Add(this.backFromTransferButton);
            this.Controls.Add(this.confirmTransferButton);
            this.Controls.Add(this.transferAmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferToListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transferFromListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox transferFromListBox;
        public System.Windows.Forms.ListBox transferToListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transferAmountTextBox;
        private System.Windows.Forms.Button confirmTransferButton;
        private System.Windows.Forms.Button backFromTransferButton;
    }
}