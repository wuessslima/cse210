public class Entry
{
    private static List<(string Date, string Question, string Answer)> history = new List<(string, string, string)>();

    private static List<string> phrases = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you learn today?",
        "What goal do you want to achieve this week?"
    };

    private string _selectedPhrase;
    private string _userAnswer;

    public Entry()
    {
        Random random = new Random();
        int index = random.Next(phrases.Count);
        _selectedPhrase = phrases[index];
    }

    public void AnswerCapture()
    {
        Console.WriteLine($"\n{_selectedPhrase}");
        Console.Write("Your Answer: ");
        _userAnswer = Console.ReadLine();

        string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Armazenar as respostas temporárias
        history.Add((currentDate, _selectedPhrase, _userAnswer));

        Console.WriteLine("Answer Saved");
    }

    public static List<(string Date, string Question, string Answer)> ObtainHistory()
    {
        return history;
    }
}