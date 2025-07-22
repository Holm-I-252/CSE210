using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an activity (1-3): \n 1: Breathing \n 2: Reflection \n 3: Listing");
        string activityType = Console.ReadLine().ToLower();


        Activity activity;

        switch (activityType)
        {
            case "1":
                activity = new Breathing();
                await activity.Start("Breathing");
                await ((Breathing)activity).StartBreathing();
                break;
            case "2":
                activity = new Reflection();
                await activity.Start("Reflection");
                await ((Reflection)activity).StartReflection();
                break;
            case "3":
                activity = new Listing();
                await activity.Start("Listing");
                await ((Listing)activity).StartListing();
                break;
            default:
                Console.WriteLine("Invalid activity type. Please try again.");
                return;
        }

        activity.End();
    }
}