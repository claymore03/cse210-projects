using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetTop());
        one.SetTop(1);
        Console.WriteLine(one.GetBottom());
        one.SetBottom(1);
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(one.GetFractionString());
        
        Fraction six = new Fraction(6);
        Console.WriteLine(six.GetFractionString());
        Console.WriteLine(six.GetTop());
        six.SetTop(5);
        Console.WriteLine(six.GetBottom());
        six.SetBottom(1);
        Console.WriteLine(six.GetDecimalValue());
        Console.WriteLine(six.GetFractionString());

        
        Fraction sixOverSeven = new Fraction(6, 7);
        Console.WriteLine(sixOverSeven.GetFractionString());
        Console.WriteLine(sixOverSeven.GetTop());
        sixOverSeven.SetTop(8);
        Console.WriteLine(sixOverSeven.GetBottom());
        sixOverSeven.SetBottom(9);
        Console.WriteLine(sixOverSeven.GetDecimalValue());
        Console.WriteLine(sixOverSeven.GetFractionString());
    }
}