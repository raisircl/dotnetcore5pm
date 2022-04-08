//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    public delegate bool StudentDelegate(Student student,int fromage, int toage);
//    class AnoymousMethods
//    {
//        static bool CheckTeenAger(Student s, int fromage, int toage)
//        {
//            return s.Age >= fromage && s.Age <= toage;
//        }
//        static void Main()
//        {

//            //StudentDelegate IsTeenAger = delegate (Student student) { return student.Age >= 12 && student.Age <= 20; };
//            StudentDelegate IsTeenAger = (student,fromage,toage)=> {
//                Console.WriteLine("Hi!");
//                return student.Age >= fromage && student.Age <= toage;
//            };
//            //StudentDelegate IsTeenAger = CheckTeenAger;

//            Func<Student,int,int, bool> IsIamTeenager = (s,fromage,toage) => s.Age >= fromage && s.Age <= toage;

//            List<Student> students = new List<Student>() {
//            new Student(){RollNo=1001, Name="Anil", Age=15 },
//            new Student(){RollNo=1002, Name="Suil", Age=25 },
//            new Student(){RollNo=1003, Name="Jatin", Age=12 },
//            new Student(){RollNo=1004, Name="Vijay", Age=9 },
//            new Student(){RollNo=1005, Name="Ankit", Age=17 },
//            new Student(){RollNo=1006, Name="Lalit", Age=18 },
//            new Student(){RollNo=1007, Name="Tarun", Age=5 },
//            };
//            List<Student> teens = new List<Student>();
//            foreach(Student s in students)
//            {
//                if (IsIamTeenager(s,10,15))
//                    teens.Add(s);
//            }
//            Console.WriteLine("Teenagers List");
//            foreach(Student s in teens)
//            {
//                Console.WriteLine($"RollNo {s.RollNo}, Name {s.Name}, Age {s.Age} ");
//            }
            
//        }
//    }
//}
