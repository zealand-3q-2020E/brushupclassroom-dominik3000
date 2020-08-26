using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{ 

    public class ClassRoom
    {

        public ClassRoom()
        {
            
        }


        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public void CountStudents()
        {
          int noWinterStudents = ClassList.Where(s => (s.Season(s.BirthMonth) == "Winter")).ToList().Count();
          int noSummerStudents = ClassList.Where(s => (s.Season(s.BirthMonth) == "Summer")).ToList().Count();
          int noSpringStudents = ClassList.Where(s => (s.Season(s.BirthMonth) == "Spring")).ToList().Count();
          int noAutumnStudents =  ClassList.Where(s => (s.Season(s.BirthMonth) == "Autumn")).ToList().Count();

          Console.WriteLine($"\n- No. students born in Winter months: {noWinterStudents} \n- No. students born in Spring months: {noSpringStudents} \n- No. students born in Summer months: {noSummerStudents}\n- No. students born in Autumn months: {noAutumnStudents}");
            
        }
    }
}
