//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class FunctionCalling
//    {
//        // By Value
//        // By Reference
//        //By Out
//        static void Main()
//        {
//            int x = 5, a=20;
//            int h, e, m, sci, sst, t;
//            float p;
//            string g;

//            Console.WriteLine($"Before Call Value of x={x} and a={a}");
//            // cbv(x,a); // x is an actual arfument
//            //cbr(ref x, ref a);
//            cbo(out x, out a);
//            Console.WriteLine($"after Call Value of x={x}  and a={a}");

//            //result(h, e, m, sci, sst, out t, out p, out g);

//        }
//        static void cbv(int y,int z) // y is an formal argument
//        {
//            y = 10;  // if any change in y it does not affect Xf
//            z = 40;

//        }
//        static void cbr(ref int y, ref int z)
//        {

//            y = 10;
//            z = 40;
//        }
//        static void cbo(out int y, out int z) // unsigned 
//        {
//            // we can not use  out parameter before assignment 
//            // out parameter does not receive any value
//            //Console.WriteLine($"{y}");
//            y = 10;
//            z = 50;
//        }
//        static void result(int h, int e, int m, int sci, int sst, out int total, out float per, out string grade)
//        {
//            total = 0;
//            per = 0;
//            grade = "A";
//        }
//        static int fact(int x)
//        {
//            if (x == 1)
//                return 1;
//            else
//                return x * fact(x - 1);

//        }
//    }
//}
