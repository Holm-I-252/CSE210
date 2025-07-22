using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

public class Listing : Activity
{
    private string _listingInstructions = "This activity will help you list things you are grateful for. Take a moment to reflect on the positive aspects of your life.";
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What are some things you are looking forward to?",
        "What are some favorite memories of yours?",
        "What are some favorite places of yours?",
        "What are some favorite foods of yours?",
        "What are some favorite activities of yours?"
    };

    public async Task StartListing()
    {
        Console.WriteLine(_listingInstructions);
        await Task.Delay(5000);

        string random_prompt = _prompts[new Random().Next(_prompts.Count)];
        Console.WriteLine(random_prompt);
        List<string> userResponses = new List<string>();
        var stopwatch = new Stopwatch();
        stopwatch.Start();


        while (stopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
        {
            string userInput = Console.ReadLine();
            userResponses.Add(userInput);

        }

        stopwatch.Stop();

        Console.WriteLine("Thank you for sharing your thoughts. Here are your responses:");
        foreach (var response in userResponses)
        {
            Console.WriteLine($"- {response}");
        }
        int totalResponses = userResponses.Count;
        Console.WriteLine($"You shared {totalResponses} responses during this activity.");

    }
}