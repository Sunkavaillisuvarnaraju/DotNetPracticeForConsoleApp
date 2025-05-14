using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Bank
    {
        private int balance;

        public Bank(int depositeAmount)
        {
            balance = depositeAmount;
        }

        public void WithDrawMoney(int withdrawMoney)
        {
            if (withdrawMoney > balance)
            {
                throw new Exception("Insufficient Funds");
            }
            else if (withdrawMoney <= 0)
            {
                throw new ArgumentException("Please Pass a Positive Value");
            }
            balance -= withdrawMoney;
            Console.WriteLine("Trasaction done sucessfully");
        }

        public void DepositeAmount(int depositeMoney)
        {
            if(depositeMoney <= 0)
            {
                throw new InvalidOperationException("Amount should not be less than Zero");
            }
            balance += depositeMoney;
        }

        public int GetBalance() { return balance; }

    }
}
