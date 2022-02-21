//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppDay1
//{
//    class MyLoop
//    {
//        static void Main()
//        {
//            //int sum = 0;
//            //int f = 1;
//            //for (int i = 1; i <= 5; i++)
//            //{
//            //    sum += i;
//            //    f *= i;
//            //    Console.Write($"{i}+");
//            //}
//            //Console.Write($"\b={sum}");
//            //Console.Write($"\n The factorial is {f}");

//            //int num,i;
//            //Console.WriteLine("Enter a  number");
//            //num = Convert.ToInt32(Console.ReadLine());

//            //for(i=2;i<num;i++)
//            //{
//            //    if (num % i == 0)
//            //        break;
//            //}
//            //if (i == num)
//            //    Console.WriteLine($"{num} is prime");
//            //else
//            //    Console.WriteLine($"{num} is not prime");

//            // 1 to 100 all primes nos
//            // 123 all possible combination 

//            //-------------------- while 

//            int num, sum = 0, rev = 0;
//            Console.WriteLine("Enter a  number");
//            num = Convert.ToInt32(Console.ReadLine());
//            while (num > 0)
//            {
//                sum += num % 10;
//                rev = rev * 10 + num % 10;
//                num /= 10;

//            }
//            Console.Write($"The sum of digits {sum}");
//            Console.WriteLine($"The Rev of digits {rev}");
//            int a = 1, b = 0, c;
//            do
//            {
//                c = a + b;
//                Console.WriteLine(c);
//                a = b;
//                b = c;

//            } while (c <= 100);

//            /*
//             1. 1+2+3+4+5+6+7+8+9+10=55
//             2. enter a number print it in word   1234 => One Two Three Four

//             */

//        }
//    }
//}
