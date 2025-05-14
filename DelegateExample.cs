using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class DelegateExample
    {
        public delegate void PaymentDelegate(decimal amount);

        public static void PaypalPayment(decimal amount)
        {
            Console.WriteLine("Paypal Payment of amount " + amount);
        }

        public static void CreditCardPayment(decimal amount)
        {
            Console.WriteLine("Credit Card Payment of amount " + amount);
        }
        public static void BankTransferPayment(decimal amount)
        {
            Console.WriteLine("Bank Transfer Payment of amount " + amount);
        }

        public static void Main(string[] args)
        {
            PaymentDelegate payment = null;
            Console.WriteLine("Choose the payment option 1. PaypalPayment, 2. CreditCardPayment, 3. BankTransferPayment");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    payment = PaypalPayment;
                    break;
                case 2:
                    payment = CreditCardPayment;
                    break;
                case 3:
                    payment = BankTransferPayment;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            if (payment != null)
            {
                Console.WriteLine("Enter the amount to pay");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                payment(amount);
            }
        }
    }
}
