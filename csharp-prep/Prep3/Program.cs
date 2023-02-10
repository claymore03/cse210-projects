using System;

class Program
{
    static void Main(string[] args)
    {
        //Generate a magic number between 1 and 100
        Console.WriteLine("Welcome to Magic Number! To win, guess the magic number");

        //Loops until user "guesses" the magic number
        float magic_number = 0;
        float guess = 0;
        string answer = "";
        string play = "Y";
        
        Random randomGenerator = new Random();
        magic_number = randomGenerator.Next(1, 100);

        do
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            string user_input = Console.ReadLine();
            guess = float.Parse(user_input);

            if(guess < magic_number)
            {
                Console.WriteLine("Higher ^^^");
            }
            else if(guess > magic_number)
            {
                Console.WriteLine("Lower vvv");
            }
            else if(guess == magic_number)
            {
                Console.WriteLine("You found the magic number!");
                do {
                Console.WriteLine("Continue playing? (Y or N): ");
                answer = Console.ReadLine();
                play = answer.ToUpper();
                } while (play != "Y" && play != "N");
                magic_number = randomGenerator.Next(1, 100);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

        } while (guess != magic_number && play == "Y");
    }
}