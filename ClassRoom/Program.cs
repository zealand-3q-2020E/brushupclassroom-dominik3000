using System;
using System.Collections.Concurrent;
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
                new Student("Dominik", 11, 9),

                new Student("Justin", 12, 31)
            };



            Console.WriteLine($"{OurClass.ClassName} started on {OurClass.SemesterStart.ToString("D")}\n");
            Console.WriteLine("Students attending:");
            foreach (var student in OurClass.ClassList)
            {
                Console.WriteLine("> "+student.Name);
              
            }

           OurClass.CountStudents();

            Console.WriteLine("\n\nPress any key to close the application...");
            Console.ReadKey();

        }



    }
}
