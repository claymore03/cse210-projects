using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score here: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 90)
        {
            Console.WriteLine("You got an A! Great job.");
        }
        else if (number >= 80 && number < 90)
        {
            Console.WriteLine("You got a B! Nice.");
        }
        else if (number >= 70 && number < 80)
        {
            Console.WriteLine("You got a C! You passed the class.");
        }
        else if (number >= 60 && number < 70)
        {
            Console.WriteLine("You got a D. Better luck next time.");
        }
        else if (number < 70)
        {
            Console.WriteLine("You got a F. Study harder.");
        }
        else
        {
            Console.WriteLine("INVALID INPUT: Enter a number next time doofus.");
        }


    }
}