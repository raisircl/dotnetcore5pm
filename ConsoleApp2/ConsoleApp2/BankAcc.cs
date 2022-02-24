using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BankAcc
    {
        private int accno;
        private string name;
        private double bal;
        private static int x = 1000;
        // Property Unit - Used to give access of class members or variables outside the class
        public BankAcc()
        {
            accno = ++x;
            bal = 500;
            name = "NA";
        }
        public BankAcc(string acname, double bal)
        {
            accno = ++x;
            this.bal = bal;
            name = acname;
        }
        public BankAcc(BankAcc acc)
        {
            accno = ++x;
            bal = acc.bal;
            name = acc.name;
        }
        public int AccountNo
        {
            get { return accno; }
        }
        public string AccName
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return bal; }
        }

        public string Deposit(double amnt, string pan="")
        {
            if(amnt>=50000 && pan!="")
            bal = bal + amnt;
            else
                return $"You can not Deposit. pan number is required ";

            return $"Deposit Successfully after deposit your balance is {bal}";

        }
        public string Withdraw(double amnt)
        {
            if (amnt <= bal)
                bal = bal - amnt;
            else
                return $"Not Sufficient Balanance Your balance is {bal} but you want to withdraw {amnt}";
            
            return $"Withdraw Successfully. after withdraw your bal is {bal}";
        }


    }
}
