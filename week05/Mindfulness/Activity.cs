using System;

public class Activity
{
    private string _openingMessage;
    protected int _duration;
    private string _closeMessage;

    public Activity(int duration = 0)
    {
        _openingMessage = "Welcome to the Mindfulness Activity!";
        _duration = duration;
        _closeMessage = "Thank you for participating in the activity!";
    }

    public void SetDuration()
    {
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }
    public async Task Start(string activityType)
    {
        Console.WriteLine(_openingMessage);
        SetDuration();
        Console.WriteLine($"Starting the {activityType} activity for {_duration} seconds. Take a few seconds to prepare.");

        // Start the animation in a separate task
        var cts = new CancellationTokenSource();
        var animationTask = ShowSpinner(cts.Token);

        // Simulate a delay (e.g., 5 seconds)
        await Task.Delay(5000);

        // Stop the animation
        cts.Cancel();
        await animationTask;
        Console.Clear();    
        Console.WriteLine("Let's begin!");

    }
    public void End()
    {
        Console.WriteLine(_closeMessage);
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