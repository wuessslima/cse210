using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        int user = -1;
        while (user != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            user = int.Parse(userResponse);

            if (user != 0)
            {
                numbersList.Add(user);
            }
        }

        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of all numbers is: {sum}");

        float media = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The media of all numbers is: {media}");

        int max = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}