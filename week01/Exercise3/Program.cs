using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
}