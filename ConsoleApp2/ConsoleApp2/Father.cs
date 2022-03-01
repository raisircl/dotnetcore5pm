using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Father
    {
        public virtual void Msg()
        {
            Console.WriteLine("I am father");
        }

    }
    class Son:Father
    {
        public override void Msg()
        {
            
            Console.WriteLine("I am son");
        }
    }
}
