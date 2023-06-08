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
    public partial class Transfer : Form
    {
        private Controller controller;
        public Transfer(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void transferAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backFromTransferButton_Click(object sender, EventArgs e)
        {

        }
    }
}
