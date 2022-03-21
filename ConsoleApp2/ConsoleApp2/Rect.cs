using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rect
    {
        private int len;

        public int Length
        {
            get { return len; }
            set { len = value; }
        }
        private int bre;

        public int Breadth
        {
            get { return bre; }
            set { bre = value; }
        }

        public Rect()
        {
            Console.WriteLine("Rect class constructor called");
            len = 0;
            bre = 0;
        }
        public Rect(int l, int b)
        {
            len = l;
            bre = b;
        }
        public int Area()
        {
            return len * bre;
        }
        public override string ToString()
        {
            return ($"Rect Dimension is {Length}x{Breadth}");
        }

    }
}
