﻿using System;
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
    public partial class Deposit : Form
    {
        private Customer cust;
        internal Deposit(Customer cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting ATM\nPlease take your card");
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(cust);
            menu.deposit(textBox1.Text);
            MessageBox.Show("Account Updated\nReturning to Menu");
            MenuGui gui = new MenuGui(cust);
            this.Hide();
            gui.ShowDialog();
            this.Close();
        }
    }
}
