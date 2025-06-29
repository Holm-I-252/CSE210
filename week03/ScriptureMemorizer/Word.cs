using System;

public class Word
{
    private string _text;

    public Word(string text)
    {
        _text = text;
    }
    public void SwitchToBlank()
    {
        _text = new string('_', _text.Length);
    }
}