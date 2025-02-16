namespace HumanClassLib
{
    public class Human
    {
        // Поля класу
        private string _fullName;
        private int _age;
        private string _gender;
        private double _height;
        private double _weight;
        private string _nationality;
        private string _religion;
        private string _profession;
        private string _passportData;
        public Human(string fullName, int age, string gender, double height, double weight,
                     string nationality, string religion, string profession, string passportData)
        {
            _fullName = fullName;
            _age = age;
            _gender = gender;
            _height = height;
            _weight = weight;
            _nationality = nationality;
            _religion = religion;
            _profession = profession;
            _passportData = passportData;
        }

        public string FullName => _fullName;
        public int Age => _age;
        public string Gender => _gender;
        public double Height => _height;
        public double Weight => _weight;
        public string Nationality => _nationality;
        public string Religion => _religion;
        public string Profession => _profession;
        public string PassportData => _passportData;

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
                public override string ToString()
        {
            return $"Ім'я: {FullName}\nВік: {Age}\nСтать: {Gender}\nЗріст: {Height} м\n" +
                   $"Вага: {Weight} кг\nНаціональність: {Nationality}\nВіросповідання: {Religion}\n" +
                   $"Професія: {Profession}\nПаспортні дані: {PassportData}\n" +
                   $"Індекс маси тіла (BMI): {CalculateBMI():F2}";
        }
    }
}
