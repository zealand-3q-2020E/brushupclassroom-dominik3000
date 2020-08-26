using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom OurClass = new ClassRoom();
            OurClass.ClassName = "Computer Science Semester 3";
            OurClass.SemesterStart = new DateTime(2020,08,24);
            OurClass.ClassList = new List<Student>()
            {
                new Student("Andreas", 7, 2),
                new Student("Justin", 12, 31)
            };
        }
    }
}
