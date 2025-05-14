using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Encapsulation
    {
        private decimal _balance;

        public Encapsulation(decimal balance)
        {
            if(balance < 0)
            {
                throw new Exception("Balance can not be negative");
            }
            _balance = balance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void DepositeAmount(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount can not be negative");
            }
            _balance += amount;
        }

        public void WithDrawMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount can not be negative");
            }
            if (_balance < amount)
            {
                throw new ArgumentException("Insufficient balance");
            }
            _balance -= amount;
        }

        public static void Main(string[] args)
        {
            Encapsulation b1 = new Encapsulation(500);
            Console.WriteLine($"Current Balance is:{b1.GetBalance()}");
            b1.DepositeAmount(500);
            Console.WriteLine($"Current Balance is:{b1.GetBalance()}");
            b1.WithDrawMoney(500);
            Console.WriteLine($"Current Balance is:{b1.GetBalance()}");
            Console.ReadLine();
        }
    }
}
