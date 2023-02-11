using System;

class Program
{
    static void Main(string[] args)
    {
        //Create space to collect numbers from the user
        List<float> numbers;
        numbers = new List<float>();

        int items = numbers.Count;

        float thing = 0;
        float new_num = thing;

        //Prompt user to enter a number
        do{
            Console.WriteLine("Add a number to the list: ");
            string user_input = Console.ReadLine();
            new_num = float.Parse(user_input);

            //Add the user's input to the numbers list
            numbers.Add(new_num);

            items = numbers.Count;

            //Ask user to add more numbers
            // Console.WriteLine("Add more numbers to the list?");
            // string choice = Console.ReadLine();
            // answer = choice.ToUpper();
        }while(new_num != 0);

        // Console.WriteLine($"Numbers in your list: {string.Join(",", numbers)}");
        // Console.WriteLine($"Total number of items in the list: {numbers.Count}");
        
        //Total sum of numbers in list
        Console.WriteLine($"Sum of numbers: {numbers.Sum()}");
        //Average of numbers in list
        Console.WriteLine($"Average of numbers: {Queryable.Average(numbers.AsQueryable())}");
        //Largest number in list
        Console.WriteLine($"The largest number is: {numbers.Max()}");
       
    }
}