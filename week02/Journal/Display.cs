using System;
using System.Collections.Generic;

public class Display
{
    public void ShowAnswers()
    {
        // Mostrar as respostas carregadas do arquivo e as temporárias
        var combinedHistory = Load.history.Concat(Entry.ObtainHistory()).ToList();

        if (combinedHistory.Count == 0)
        {
            Console.WriteLine("No question or answer saved");
            return;
        }

        Console.WriteLine("\n=== Saved Answers ===");
        foreach (var item in combinedHistory)
        {
            Console.WriteLine($"Date: {item.Date}");
            Console.WriteLine($"Question: {item.Question}");
            Console.WriteLine($"Answer: {item.Answer}\n");
        }
    }
}