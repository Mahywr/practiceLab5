using System;

public class Square
{
    public static void Main()
    {
        Console.Write("Enter a number: "); // Prompt the user for input
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int squared = number * number;
            Console.WriteLine("The square of {0} is {1}", number, squared);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
