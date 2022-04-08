using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ProgramLinq
    {
        static void Main()
        {
            string[] names = {"Manjeet","Vinod","Neelam","Naresh","Gaurav","Rai Singh","Raman"};
            var result = from name in names where name.Contains("a") select name;
            
            foreach(var name in result)
            {
                Console.WriteLine($"{name}");
            }

            List<Student> students = new List<Student>()
            {
                            new Student(){RollNo=1001, Name="Anil", Age=15 },
                            new Student(){RollNo=1002, Name="Suil", Age=25 },
                            new Student(){RollNo=1003, Name="Jatin", Age=12 },
                            new Student(){RollNo=1004, Name="Vijay", Age=9 },
                            new Student(){RollNo=1005, Name="Ankit", Age=17 },
                            new Student(){RollNo=1006, Name="Lalit", Age=18 },
                            new Student(){RollNo=1007, Name="Tarun", Age=5 },
            };

            Student[] teenagers = students.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            Student st = students.Where(s => s.RollNo == 1005).FirstOrDefault();
           
          
        }

    }
}
