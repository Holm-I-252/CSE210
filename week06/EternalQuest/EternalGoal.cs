using System;

public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
        : base(title, description, points)
    {
    }

    public override void CompleteGoal(User user)
    {
        Console.WriteLine($"Eternal goals cannot be completed in the traditional sense, but they can be tracked. {_points} points will be awarded for working on the eternal goal '{_title}'.");
        user.AddPoints(_points);
    }
}