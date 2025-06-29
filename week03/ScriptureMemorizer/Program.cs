using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Please enter the book name:");
        string book = Console.ReadLine();
        Console.WriteLine("Please enter the chapter number:");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the starting verse number:");
        int verseStart = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you want to enter an ending verse number? (yes/no)");
        string response = Console.ReadLine().ToLower();
        int verseEnd = verseStart; // Default to the same verse if no end verse is provided
        if (response == "yes")
        {
            Console.WriteLine("Please enter the ending verse number:");
            verseEnd = int.Parse(Console.ReadLine());
        }
        Reference reference = new Reference(book, chapter, verseStart, verseEnd);
        Console.WriteLine("Please enter the scripture text:");
        string text = Console.ReadLine();
        Scripture scripture = new Scripture(text, reference.GetReference());
        Console.Clear();

        bool running = true;
        while (running)
        {
            scripture.Display();
            Console.WriteLine("Press space to hide words and continue, or 'q' to quit");
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                scripture.HideWords();
                Console.Clear();
            }
            else if (key.Key == ConsoleKey.Q)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid key pressed. Please press space to hide words or 'q' to quit.");
            }
            text = scripture.GetText();
            bool onlyUnderscores = text.All(c => c == '_');
            if (onlyUnderscores)
            {
                Console.WriteLine("Congratulations! You have memorized the scripture!");
                running = false;
            }
            }
        Console.WriteLine("Thank you for using the Scripture Memorizer!");
        Console.WriteLine("Goodbye!");
        
    }
}