using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Jhon", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());


            //add a count to congratulate the user for the efforts
            int totalWords = scripture.WordCount();
            int hiddenWords = scripture.HiddenWordCount();
            if (hiddenWords > totalWords / 2)
            {
                Console.WriteLine("\nCongratulations on your effort so far, keep going, you can do it!");
            }


            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words have been hidden! Program terminated.");
                break;
            }
        }
    }
}