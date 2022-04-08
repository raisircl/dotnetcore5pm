using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class IntExtensionMethods
    {
        public static bool IsGreater(this int x, int value)
        {
            return x > value;
        }
        public static bool IsPositive(this int x)
        {
            return x > 0;
        }
    }
}
