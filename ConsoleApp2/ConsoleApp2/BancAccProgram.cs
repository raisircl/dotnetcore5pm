//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class BancAccProgram
//    {
//        static void Main()
//        {
//            BankAcc b1 = new BankAcc();
//            BankAcc b2 = new BankAcc("Vinod",5000);
//            BankAcc b3 = new BankAcc(b2);

//            b1.AccName = "Manjeet"; // set
//            string response;
//            response = b1.Deposit(50000,"CKEPS4964D");
//            Console.WriteLine(response);

//            response=b2.Withdraw(6000);

//            Console.WriteLine(response);
//            Console.WriteLine($"Bank Acc Detail Accno {b1.AccountNo}, AccName {b1.AccName}, Acc Bal {b1.Balance}");
//            Console.WriteLine($"Bank Acc Detail Accno {b2.AccountNo}, AccName {b2.AccName}, Acc Bal {b2.Balance}");
//            Console.WriteLine($"Bank Acc Detail Accno {b3.AccountNo}, AccName {b3.AccName}, Acc Bal {b3.Balance}");


//        }
//    }
//}
