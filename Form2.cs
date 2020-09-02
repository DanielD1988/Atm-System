using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 4)
            {
                textBox1.Text = textBox1.Text.Substring(0, 3);
            }

        }
        public void checkPin()
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting ATM\nPlease take your card");
            Application.Exit();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText("C:\\Users\\danny\\OneDrive\\Desktop\\C#\\Atm-System\\customerData.json");
            List<Customer> customer = JsonConvert.DeserializeObject<List<Customer>>(jsonString);//make customer objects from string
            foreach (Customer pin in customer)
            {
                if (string.Equals(pin.getPin(), textBox1.Text))
                {
                    Menu menu = new Menu(pin);//pass customer object that has matching pin to menu system
                    MenuGui gui = new MenuGui(pin);
                    this.Hide();
                    gui.ShowDialog();
                    this.Close();
                }
            }
            MessageBox.Show("Invalid pin");
        }
    }
}
