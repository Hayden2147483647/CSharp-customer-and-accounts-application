namespace BIT706_A2_PartA
{
    partial class Main_form
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
            this.buttonToCustomers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToCustomers
            // 
            this.buttonToCustomers.Location = new System.Drawing.Point(117, 106);
            this.buttonToCustomers.Name = "buttonToCustomers";
            this.buttonToCustomers.Padding = new System.Windows.Forms.Padding(5);
            this.buttonToCustomers.Size = new System.Drawing.Size(115, 71);
            this.buttonToCustomers.TabIndex = 0;
            this.buttonToCustomers.Text = "Manage Customers";
            this.buttonToCustomers.UseVisualStyleBackColor = true;
            this.buttonToCustomers.Click += new System.EventHandler(this.buttonToCustomers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyBank";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(366, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToCustomers;
        private System.Windows.Forms.Label label1;
    }
}