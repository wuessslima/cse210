using System;

public class Menu
{
    public void ShowMenu()
    {
        string option = "";

        while (option != "5")
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Save");
            Console.WriteLine("4 - Load");
            Console.WriteLine("5 - Exit");
            Console.Write("Choose an option: ");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Entry entry = new Entry();
                    entry.AnswerCapture();
                    break;

                case "2":
                    Display display = new Display();
                    display.ShowAnswers();
                    break;

                case "3":
                    Console.Write("Put the name of the archive to save (ex.: answers.csv): ");
                    string nameArchiveSave = Console.ReadLine();
                    Save save = new Save();
                    save.SaveAnswers(nameArchiveSave);
                    break;

                case "4":
                    Console.Write("Put the name of the archive to load (ex.: answers.csv): ");
                    string nameArchiveLoad = Console.ReadLine();
                    Load load = new Load();
                    load.LoadAnswers(nameArchiveLoad);
                    break;

                case "5":
                    Console.WriteLine("Exiting the program...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option! Please choose a valid number.");
                    break;
            }
        }
    }
}