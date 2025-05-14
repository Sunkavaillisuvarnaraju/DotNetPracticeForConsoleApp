//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OopsProject
//{
//    public class AbstractionExample
//    {
//        public static void Main(string[] args)
//        {
//            {
//                Console.WriteLine("Transaction doing SBI Bank");
//                IBank sbi = BankFactory.GetBankObject("SBI");
                
//                //sbi.ValidateCard();
//                sbi.WithdrawMoney();
//                sbi.CheckBalanace();
//                sbi.BankTransfer();
//                sbi.MiniStatement();

//                Console.WriteLine("\nTransaction doing AXIX Bank");
//                IBank AXIX = BankFactory.GetBankObject("AXIX");
//                AXIX.ValidateCard();
//                AXIX.WithdrawMoney();
//                AXIX.CheckBalanace();
//                AXIX.BankTransfer();
//                AXIX.MiniStatement();

//                Console.Read();
//            }

//        }
//    }
//}
