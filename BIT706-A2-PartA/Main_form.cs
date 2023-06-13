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
    public partial class Main_form : Form
    {
        public static Controller controller = new Controller();

        public Main_form()
        {
            InitializeComponent();
        }

        private void buttonToCustomers_Click(object sender, EventArgs e)
        {
            controller.getSerializer().deSerializing();
            this.Hide();
            controller.allCustomerGUI();
            for (int i = 0; i < controller.getAllCustomers().allCustomersList.Count; i++)
            {
                controller.getAllCustomers().allCustomerslistBox.Items.Add(controller.getAllCustomers().allCustomersList.ElementAt(i).getInfo());
                controller.custID = controller.getAllCustomers().allCustomersList.ElementAt(i).getId() + 1;
            }
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.onClose();
        }
    }
}
