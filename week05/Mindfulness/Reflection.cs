using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

public class Reflection : Activity
{
    private string _reflectionOpeningMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Reflect on a moment when you felt proud of yourself.",
        "Consider a situation where you showed courage.",
        "Remember a time when you helped someone in need.",
        "Recall a moment when you learned something valuable from a mistake.",
        "Think about a time when you had to be patient.",
        "Reflect on a situation where you had to adapt to change.",
        "Consider a moment when you had to make a difficult decision.",
        "Remember a time when you had to persevere through adversity.",
        "Recall a moment when you had to trust your instincts."
    };

    public async Task StartReflection()
{
    Console.WriteLine(_reflectionOpeningMessage);
    await Task.Delay(5000);

    var stopwatch = new Stopwatch();
    stopwatch.Start();

    while (stopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
    {
        // Randomly select a prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("\nTake a moment to reflect on this prompt...\n");
        Console.WriteLine(prompt);

        // Start the animation
        var cts = new CancellationTokenSource();
        var animationTask = ShowSpinner(cts.Token);

        // Calculate remaining time
        var timeLeft = TimeSpan.FromSeconds(_duration) - stopwatch.Elapsed;
        var delay = timeLeft < TimeSpan.FromSeconds(5) ? timeLeft : TimeSpan.FromSeconds(5);

        await Task.Delay(delay);

        // Stop the animation
        cts.Cancel();
        await animationTask;

        Console.Clear();

        // Optional: short pause between prompts
        if (stopwatch.Elapsed < TimeSpan.FromSeconds(_duration))
        {
            await Task.Delay(1000);
        }
    }

    stopwatch.Stop();
}


    static async Task ShowSpinner(CancellationToken token)
    {
        var spinner = new[] { '|', '/', '-', '\\' };
        int counter = 0;

        while (!token.IsCancellationRequested)
        {
            Console.Write(spinner[counter % spinner.Length]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            await Task.Delay(100);
        }
    }
}   
