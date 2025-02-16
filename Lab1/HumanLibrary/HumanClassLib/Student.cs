namespace HumanClassLib
{
    public class Student : Human
    {
        public string StudentID { get; set; }
        public string Group { get; set; }

        public Student(string fullName, int age, string gender, double height, double weight,
                       string nationality, string religion, string profession, string passportData,
                       string studentID, string group)
            : base(fullName, age, gender, height, weight, nationality, religion, profession, passportData)
        {
            StudentID = studentID;
            Group = group;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nНомер залікової книжки: {StudentID}\n" +
                   $"Група: {Group}\n";
        }
    }
}
