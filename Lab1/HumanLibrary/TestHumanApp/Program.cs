using System;
using HumanClassLib;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Human person = new Human("Олександр Іванов", 30, "Чоловік", 1.75, 75,
                                 "Українець", "Християнство", "Інженер", "AB123456");
                Console.WriteLine(person.ToString());
        Console.OutputEncoding = System.Text.Encoding.UTF8;

    }
}
