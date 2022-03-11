using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Baloon
    {
        private delegate void BangDel(string msg);
        private event BangDel Bang;
        public delegate void PumpDel(object sender);
        public event PumpDel Pump;
       
        public Baloon()
        {
            _dia = 2;
            _pond = 1;
            Bang += Baloon_Bang;
        }

        private int _dia;
        

        public int Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }
        private int _pond;

        public int Pond
        {
           
            get { return _pond; }
            set { _pond = value; }
        }

        public void FillAir()
        {
            _pond++;
            _dia = _pond * 2;
            
            Pump(this);
            
            if (_dia >= 5)
                Bang($"Booooooooooooooooooom because dia {_dia}");
              
        }

        private void Baloon_Bang(string msg)
        {
            Console.WriteLine(msg);
        }

    }
    class BaloonPrgram
    {
        static void Main()
        {
            Baloon baloon = new Baloon();
            // create event handler
            baloon.Pump += Baloon_Pump;
            // raise event
            baloon.FillAir();
            baloon.FillAir();
        }

        private static void Baloon_Pump(object sender)
        {
            Baloon baloon = (Baloon)sender;
            Console.WriteLine($"Baloon Dia {baloon.Dia} and air in baloon is {baloon.Pond} pond.");
        }
    }
}
