using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bank
    {
        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                // validate the value
                if (value < 0)
                {
                    Console.WriteLine("value cannot be negative");
                }
                else
                {
                    _balance = value;
                }
            }
        }

        private double _transfer;
        public double Transfer
        {
            get
            {
                return _transfer;
            }
            set
            {
                if(value > 0 && value < _balance) 
                {
                    Console.WriteLine("Your transfer is complete");
                }
                else
                {
                    Console.WriteLine("You dont have enough money");
                }
            }
           
        }


        public string Loan(int sum,int salary)
        {
            if(sum <= 10 * salary)
            {
                return "Your loan will be ready in 3 days";
            }
            else
            {
                return "Your loan has beeen decined";
            }
        }
    }
}


