namespace HumanClassLib
{
    public class Worker : Human
    {
        public string Department { get; set; }
        public string Position { get; set; }

        public Worker(string fullName, int age, string gender, double height, double weight,
                      string nationality, string religion, string profession, string passportData,
                      string department, string position)
            : base(fullName, age, gender, height, weight, nationality, religion, profession, passportData)
        {
            Department = department;
            Position = position;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nВідділ: {Department}\n" +
                   $"Посада: {Position}\n";
        }
    }
}
