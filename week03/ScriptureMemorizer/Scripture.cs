using System;
using System.IO;

public class Scripture
{
    private string _text;
    private string _reference;

    public Scripture(string text, string reference)
    {
        _text = text;
        _reference = reference;
    }

    public void Display()
    {
        Console.WriteLine($"Scripture Reference: {_reference}");
        Console.WriteLine($"Text: {_text}");
    }

    public string GetText()
    {
        return _text;
    }
    public void HideWords()
    {
        string[] words = _text.Split(' ');
        Random random = new Random();
        int wordsToHide = random.Next(1, 4);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Length);
            words[index] = new string('_', words[index].Length);
        }
        _text = string.Join(" ", words);
    }
}