using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal App!");
        Console.WriteLine("1. New Journal Entry");
        Console.WriteLine("2. View Journal Entries");
        Console.WriteLine("3. Save Journal Entries");
        Console.WriteLine("4. Load Journal Entries");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
        string userChoice = Console.ReadLine();
        while (userChoice != "5")
        {
            switch (userChoice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal entries saved.");
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal entries loaded.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine("Choose another option or exit:");
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. View Journal Entries");
            Console.WriteLine("3. Save Journal Entries");
            Console.WriteLine("4. Load Journal Entries");
            Console.WriteLine("5. Exit");
            userChoice = Console.ReadLine();
        }
        

    }
    
}