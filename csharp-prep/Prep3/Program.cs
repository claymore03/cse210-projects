using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompt user to enter a magic number
        Console.WriteLine("What is the magic number?");
        string magic = Console.ReadLine(); 
        float answer = float.Parse(magic);

        //Loops until user "guesses" the magic number
        float guess = 0;
        do
        {
        Console.WriteLine("Enter a guess: ");
        string user_input = Console.ReadLine();
        guess = float.Parse(user_input);

        if(guess < answer)
        {
            Console.WriteLine("Higher ^^^");
        }
        else if(guess > answer)
        {
            Console.WriteLine("Lower vvv");
        }
        else if(guess == answer)
        {
            Console.WriteLine("You found the magic number!");
        }
        else
        {
            Console.WriteLine("INVALID INPUT");
        }
        } while (guess != answer);
    }
}