public class Save
{
    public void SaveAnswers(string archiveName)
    {
        List<(string Date, string Question, string Answer)> history = Entry.ObtainHistory();

        if (history.Count == 0)
        {
            Console.WriteLine("Doesn't have answers to save.");
            return;
        }

        try
        {
            using (StreamWriter writer = new StreamWriter(archiveName, append: true))
            {
                foreach (var item in history)
                {
                    writer.WriteLine($"{item.Date}|{item.Question}|{item.Answer}"); // Correção do separador
                }
            }
            Console.WriteLine($"Answers Saved with Success in {archiveName}!");

            // Limpar a lista após salvar
            Entry.ObtainHistory().Clear();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error to save: {ex.Message}");
        }
    }
}