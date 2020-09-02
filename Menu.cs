using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_System
{
    class Menu
    {
        private Customer cust;
        
        public Menu(Customer customer)
        {
            cust = customer;
        }
        
        public string getBalance()
        {
            return "" + cust.getBalance();
        }
        
        public bool withdraw(string amount)
        {
            double cash = Convert.ToDouble(amount);
            if (cash <= cust.getBalance())
            {
                cust.setBalance(cust.getBalance() - cash);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void deposit(string amount)
        {
            double cash = Convert.ToDouble(amount);
            cust.setBalance(cust.getBalance() + cash);
        }
        public void saveCustomersState()
        {

        }
    }
}
