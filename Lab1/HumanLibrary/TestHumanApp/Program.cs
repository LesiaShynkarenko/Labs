using System;
using HumanClassLib;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Human person = new Human("Іван", 30, "Чоловік", 1.8, 75, "Українець", "Християнство", "Програміст", "AB123456");
        Student student = new Student("Марія", 20, "Жінка", 1.65, 55, "Українка", "Будизм", "Студент", "CD789012", "S12345", "КН-22");
        Worker worker = new Worker("Петро", 40, "Чоловік", 1.75, 85, "Українець", "Атеїст", "Інженер", "EF345678", "IT", "DevOps");

        Console.WriteLine("==== Людина ====");
        Console.WriteLine(person);
        Console.WriteLine();
        Console.WriteLine("==== Студент ====");
        Console.WriteLine(student);
        Console.WriteLine("==== Працівник ====");
        Console.WriteLine(worker);
        Console.ReadLine();

    }
}
