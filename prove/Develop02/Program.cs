using System;

class Program
{
    
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal._entries = null; 
        Console.WriteLine("Welcome to Journaltron 6000");
        while(true)
        {
            

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Record an entry.");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                myJournal.DisplayPrompt();
                string text = Console.ReadLine();
                myJournal.SaveEntry(text);
            }
            else if (option == "2")
            {
                myJournal.DisplayEntries();
            }
            else if (option == "3")
            {
                Console.WriteLine("Save to: ");
                string fileName = Console.ReadLine();
                string fullPath = @".\" + fileName;
                File.WriteAllText(fullPath, myJournal.StringEncode());
            }
            else if (option == "4")
            {
                Console.WriteLine("Name of file: ");
                string fileName = Console.ReadLine();
                string readText = File.ReadAllText(@".\" + fileName);
                myJournal.StringDecode(readText);
            }
            else if (option == "5")
            {
                break;
            }
            else
            {
                continue;
            }
        }
    }
}