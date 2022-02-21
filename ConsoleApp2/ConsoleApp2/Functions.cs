//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class Functions
//    {
//        static void Main()
//        {
//            msg();
//            table(5);
//            Console.WriteLine($"factorial is {fact(5)}");
//            double r = 4.3, a;
//            a = getPI() * r * r;
//            Console.WriteLine($"Circle area is {a}");

//        }
//        static void msg()
//        {
//            Console.WriteLine("Hello User Welcome to function");
//        }
//        static void table(int num)
//        {
//            for (int i = 1; i <=10; i++)
//            {
//                Console.WriteLine($"{num}x{i}={num * i}");
//            }
//        }
//        static int fact(int num)
//        {
//            int f = 1;
//            for (int i = 1; i <= num; i++)
//            {
//                f *= i;
//            }
//            return f;
//        }
//        static double getPI()
//        {
//            return 3.14;
//        }

//    }
//}
