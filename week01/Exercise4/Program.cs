using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Enter a number (or type 0 to finish):");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number == 0)
            {
                running = false;
            }
            else
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        double avg = numbers.Average();
        int biggest = 0;
        foreach (int num in numbers)
        {
            sum += num;
            if (num > biggest)
            {
                biggest = num;
            }

        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Biggest number: {biggest}");
    }
}