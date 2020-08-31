using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_System
{
    class Customer
    {
        private String pinNumber;
        private string name;
        private double balance;
        public Customer()
        {
            pinNumber = "1111";
            name = "John Smith";
            balance = 0;
        }
        public bool checkPin(String pin)
        {
            if (string.Equals(pinNumber, pin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        public double getBalnace()
        {
            return balance;
        }
    }
}
