using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt user to enter score
        Console.WriteLine("Enter your score here: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        //Display letter grade based of score
        if (number >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (number >= 80 && number < 90)
        {
            Console.WriteLine("Grade: B");
        }
        else if (number >= 70 && number < 80)
        {
            Console.WriteLine("Grade: C");
        }
        else if (number >= 60 && number < 70)
        {
            Console.WriteLine("Grade: D");
        }
        else if (number < 70)
        {
            Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("INVALID INPUT: Enter a number next time doofus.");
        }

        //Figure out if PASS or FAIL
        if(number >= 70)
        {
            Console.WriteLine($"You PASSED with a {grade}%");
        }
        else if(number < 70)
        {
            Console.WriteLine($"You FAILED with a {grade}%");
        }
        else
        {
            Console.WriteLine("Enter a number fool!");
        }


    }
}