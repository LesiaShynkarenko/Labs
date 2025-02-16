using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanClassLib;

namespace HumanClassLib.Tests
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void TestBMICalculation()
        {
            // Arrange
            Human person = new Human("Іван", 30, "Чоловік", 1.8, 75, "Українець", "Християнство", "Програміст", "AB123456");

            // Act
            double bmi = person.CalculateBMI();

            // Assert
            Assert.AreEqual(23.15, bmi, 0.01); // Очікуване значення BMI ≈ 23.15
        }

        [TestMethod]
        public void TestStudentToString()
        {
            Student student = new Student("Марія", 20, "Жінка", 1.65, 55, "Українка", "Католицизм", "Студент", "CD789012", "S12345", "КН-22");

            string result = student.ToString();
            Assert.IsTrue(result.Contains("Марія") && result.Contains("S12345"));
        }
    }
}
