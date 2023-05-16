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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void buttonToCustomers_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.FormClosed += (s, args) => this.Close();
            main.Show();
        }
    }
}
