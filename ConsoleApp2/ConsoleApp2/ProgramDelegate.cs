using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ProgramDelegate
    {
        public delegate void Print(int value);
       static void Main()
        {
            //Print print;
            //print = PrintNumber;
            //print(10000);
            //print = PrintMoney;
            //print(10000);

            //PrintHelper(PrintNumber, 100000);
            //PrintHelper(PrintMoney, 100000);
            Print print = PrintNumber;
            print += PrintMoney;
            print(100000);

        }
        static void PrintNumber(int num)
        {
            Console.WriteLine("Your number is {0,-12:N0}", num);

        }
        static void PrintMoney(int money)
        {
            Console.WriteLine("Your Money is {0:C}", money);

        }
        static void PrintHelper(Print print, int num)
        {
            print(num);
        }
    }
}
