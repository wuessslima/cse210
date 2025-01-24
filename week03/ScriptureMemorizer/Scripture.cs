using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n" + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}