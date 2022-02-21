using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FunctionCalling
    {
        // By Value
        // By Reference
        //By Out
        static void Main()
        {
            int x = 5, a=20;
            Console.WriteLine($"Before Call Value of x={x} and a={a}");
           // cbv(x,a); // x is an actual arfument
           cbr(ref x, ref a);
            Console.WriteLine($"after Call Value of x={x}  and a={a}");


        }
        static void cbv(int y,int z) // y is an formal argument
        {
            y = 10;  // if any change in y it does not affect Xf
            z = 40;

        }
        static void cbr(ref int y, ref int z)
        {
            y = 10;
            z = 40;
        }
    }
}
