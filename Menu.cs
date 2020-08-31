using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_System
{
    class Menu
    {
        private Customer cust;
        public Menu(Customer cust)
        {
            this.cust = cust;
        }
        public int withdraw(double amount)
        {
           if(amount <= cust.getBalnace())
            {
                cust.setBalance(cust.getBalnace() - amount);
                return 0;
            }
            else
            {
                return -1;
            }
        }

    }
}
