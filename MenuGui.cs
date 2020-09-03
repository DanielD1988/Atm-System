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
    public partial class MenuGui : Form
    {
        private Customer customer;
        internal MenuGui(Customer cust)
        {
            InitializeComponent();
            this.customer = cust;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(customer);
            showBalance bal = new showBalance(menu.getBalance(),customer);
            this.Hide();
            bal.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw draw = new Withdraw(customer);
            this.Hide();
            draw.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposit dept = new Deposit(customer);
            this.Hide();
            dept.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting ATM\nPlease take your card");
            Application.Exit();
        }
    }
}
