using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is yout grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string text = "";

        if (percentage >= 90)
        {
            text = "A";
        }
        else if (percentage >= 80)
        {
            text = "B";
        }
        else if (percentage >= 70)
        {
            text = "C";
        }
        else if (percentage >= 60)
        {
            text = "D";
        }
        else
        {
            text = "F";
        }

        Console.WriteLine($"Your grade is: {text}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed! Congratulations");
        }
        else
        {
            Console.WriteLine("Sorry about that, good luck next time");
        }
    }
}