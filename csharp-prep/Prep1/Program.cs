using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string first_name = Console.ReadLine();

        Console.WriteLine("Enter your last name: ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"The name is {last_name}, {first_name} {last_name}.");
    }
}