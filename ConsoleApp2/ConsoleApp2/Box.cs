using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Box:Rect
    {
        private int ht;

        public int Height
        {
            get { return ht; }
            set { ht = value; }
        }
        public Box()
        {
            Console.WriteLine("Box class constructor called");
            ht = 0;
        }
        public Box(int l, int b, int h):base(l,b)
        {
           
            ht = h;
        }
        public int Vol()
        {
            return Area() * ht;
        }
        public override string ToString()
        {
            return $"Box Dimension {Length}x{Breadth}x{Height}, Area={Area()}, Volumenr={Vol()}";
        }
    }
}
