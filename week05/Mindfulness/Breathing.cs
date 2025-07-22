using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

public class Breathing : Activity
{
    private string _breathingInstructions = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public async Task StartBreathing()
    {
        Console.WriteLine(_breathingInstructions);
        await Task.Delay(5000);

        int timePassed = 0;
        while (timePassed < _duration)
        {
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Breathe in...");
                Console.WriteLine($"{i}");
                await Task.Delay(1000); 
                Console.Clear();
            }
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine("Breathe out...");
                Console.WriteLine($"{i}");
                await Task.Delay(1000); 
                Console.Clear();
            }
            timePassed += 8; // Each cycle takes 8 seconds
        }
    }
}