using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor for scripture with a single verse
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Constructor for scripture with a verse range
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        Random random = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
