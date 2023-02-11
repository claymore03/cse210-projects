using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name: {name}");
        
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string user_input = Console.ReadLine();
        int number = int.Parse(user_input);
        Console.WriteLine($"Your number: {number}");
        
        return number;
    }

    static double SquareNumber(int square)
    {
        
        double root = Math.Sqrt(square);
        Console.WriteLine($"Your square root: {root}");

        return root;
    }

    static void DisplayResults(string name, double root)
    {
        Console.WriteLine($"{name}, the square root of your number is {root}");
    }
    
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResults(name, SquareNumber(number));
    }
}