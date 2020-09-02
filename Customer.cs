using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_System
{
    class Customer
    {
        public Customer()
        {
        }
        //set and get
        public string name { get; set; }
        public string pinNumber { get; set; }
        public double balance { get; set; }
        
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
        public double getBalance()
        {
            return balance;
        }
        public string getPin()
        {
            return pinNumber;
        }
        public string recipt()
        {
            string print = "";
            print += "Account Name: " + name +"\n";
            print += "Account Number: xxxxxxxxxx" + "\n";
            print += "Account Number: " + balance + "\n";
            return print;
        }
    }
}
