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
    public partial class ConfirmCard : Form
    {
        public ConfirmCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openNextPage();
        }
        public void openNextPage()
        {
            EnterPin newForm = new EnterPin();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
