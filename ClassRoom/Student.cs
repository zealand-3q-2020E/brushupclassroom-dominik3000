using System;

namespace ClassRoom
{
    public class Student
    {
        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public string Season(int monthOfBirth)
        {

            if (monthOfBirth == 12 || monthOfBirth == 1 || monthOfBirth == 2)
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

            if (BirthMonth > 12 || BirthMonth <1 || BirthDay > 31 || BirthMonth<1)
            {
                throw new ArgumentOutOfRangeException("Incorrect date of birth","The birth date is out of range.");
                return null;
            }

            return null;
        }


    }
}