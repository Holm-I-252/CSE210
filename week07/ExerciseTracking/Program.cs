using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[3];
        activities[0] = new Running(30, DateTime.Now, 5.0);
        activities[1] = new Cycling(45, DateTime.Now, 20.0);
        activities[2] = new Swimming(60, DateTime.Now, 30.0);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}