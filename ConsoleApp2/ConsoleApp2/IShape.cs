using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IShape
    {
        public void area();
        public void perimeter();
        public void msg();
    }
    interface Common
    {
        public void fun();
    }
    class Circle : IShape, Common
    {
        public void area()
        {
            Console.WriteLine("Area of circle");

        }

        public void fun()
        {
            Console.WriteLine("fun of circle from common");
        }

        public void msg()
        {
            Console.WriteLine("msg of circle");
        }

        public void perimeter()
        {
            Console.WriteLine("perimeter of circle");
        }
    }
    class Triangle : IShape
    {
        public void area()
        {
            Console.WriteLine("Area of tri");
        }

        public void msg()
        {
            Console.WriteLine("fun of tri");
        }

        public void perimeter()
        {
            Console.WriteLine("perimeter of tri");
        }
    }
}
