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



            Console.WriteLine($"{OurClass.ClassName} started on {OurClass.SemesterStart.ToString("D")}\n");
            Console.WriteLine("Students attending:");
            foreach (var student in OurClass.ClassList)
            {
                Console.WriteLine("> "+student.Name);
              
            }

            Console.WriteLine("\n\nPress any key to close the application...");
            Console.ReadKey();

        }

        public string Season(int monthOfBirth)
        {

            if (monthOfBirth == 12 || monthOfBirth ==1 || monthOfBirth ==2 )
            {
                return "Winter";
            }


            if (monthOfBirth == 3 || monthOfBirth == 4 || monthOfBirth == 5)
            {
                return "Spring";
            }

            if (monthOfBirth == 6 || monthOfBirth == 7 || monthOfBirth == 8)
            {
                return "Summer";
            }

            if (monthOfBirth == 9 || monthOfBirth == 10 || monthOfBirth == 11)
            {
                return "Autumn";
            }

            return "This dude was born in an impossible time.";
        }



    }
}
