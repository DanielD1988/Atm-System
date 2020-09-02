using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_System
{
    public partial class showBalance : Form
    {
        private Customer cust;
        internal showBalance(string balance,Customer cust)
        {
            InitializeComponent();
            textBox1.Text = balance;
            this.cust = cust;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting ATM\nPlease take your card");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuGui gui = new MenuGui(cust);
            this.Hide();
            gui.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
