using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GenericCollectionPractice
    {
        static void Main()
        {
            List<int> list = new List<int>();

            List<Rect> listRects = new List<Rect>();
            listRects.Add(new Rect() { Length = 10, Breadth = 20 });
            listRects.Add(new Rect() { Length = 20, Breadth = 50 });

            foreach (Rect rect in listRects)
            {
                Console.WriteLine(rect.ToString());
            }

            List<DTO> dtos = new List<DTO>();
            dtos.Add(new DTO() 
                                { Rect = new Rect() { Length=4, Breadth=7}, 
                                  Box=new Box() {Length=3, Breadth=2, Height=1 } 
                                });
            dtos.Add(new DTO()
            {
                Rect = new Rect() { Length = 2, Breadth = 2 },
                Box = new Box() { Length = 1, Breadth = 2, Height = 3 }
            });
            foreach(DTO dto in dtos)
            {
                Console.WriteLine(dto.Rect.ToString());
            }
        }

    }
    class DTO
    {
        public Rect Rect { get; set; }
        public Box Box { get; set; }
    }
}
