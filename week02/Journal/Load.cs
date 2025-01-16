public class Load
{
    public static List<(string Date, string Question, string Answer)> history = new List<(string, string, string)>();

    public void LoadAnswers(string archiveName)
    {
        if (!File.Exists(archiveName))
        {
            Console.WriteLine("File doesn't exist!");
            return;
        }

        try
        {
            history.Clear();
            using (StreamReader reader = new StreamReader(archiveName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string question = parts[1];
                        string answer = parts[2];

                        history.Add((date, question, answer));
                    }
                }
            }
            Console.WriteLine("File loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}