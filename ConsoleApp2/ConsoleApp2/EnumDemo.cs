//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    // Type - Defined by user 

//    public enum WeekDay
//    {
//        Monday=1,
//        Tuesday=2,
//        Wednesday=3,
//        Thursday=4,
//        Friday=5,
//        Saturday=6,
//        Sunday=7
//    }
//    public class Book
//    {
        
//        public string name;
//        public string author;
//        public string isbn;
//        public double price;
//        public int pubyear;

//    }
//    class EnumDemo
//    {
//        static void Main()
//        {
//            int day;
//            Book book = new Book() {name="Let Us C",author="Yaswant Kanetkar",isbn="ABC123",price=290.44,pubyear=2006};
            
//            Book book1 = new Book();
//            book1.name = "C#.Net";
//            book1.price = 560.88;
//            book1.isbn = "XYZ123";
//            book1.pubyear = 2009;

//            // boxing - unboxing 
//            int num = 10;
//            object obj = book;
            
//            int num2 = (int)obj;

//            Console.WriteLine("enter day of the week");
//            day = Convert.ToInt32(Console.ReadLine());
//            WeekDay x = (WeekDay)day;
//            Console.WriteLine($"Today is {x}");
//        }
//    }
//}
