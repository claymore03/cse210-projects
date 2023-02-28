using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Machine");
        Console.WriteLine();
        
        Reference singleVerse = new Reference("John", 3, 16);

        Reference multiVerse = new Reference("Moroni", 10, 3, 5);

        Scripture text = new Scripture("Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how merciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and ponder it in your hearts. And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");

        Console.WriteLine(multiVerse.MultiVerseScripture());
        Console.WriteLine(text.DisplayText());

        Console.WriteLine();

        Console.WriteLine("Press the ENTER key to hide words, or type QUIT to end the program.");
        string option = Console.ReadLine();
        do
        {
            if (option != "quit")
            {
                Console.Clear();
            }
            else if (option == "quit")
            {
                break;
            }
            else
            {
                continue;
            }

        } while (option != "quit");
    }
}