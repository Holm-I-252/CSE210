using System;

public class Entry
{
    public string Prompt;
    public string Response;
    public DateTime Date;

    public void Display()
    {
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

}