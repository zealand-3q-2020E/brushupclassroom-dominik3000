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
    }
}