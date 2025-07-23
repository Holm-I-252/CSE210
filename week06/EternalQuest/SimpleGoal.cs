using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string title, string description, int points, bool isCompleted = false)
        : base(title, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override void CompleteGoal(User user)
    {
        if (_isCompleted)
        {
            Console.WriteLine($"Goal '{_title}' has already been completed.");
            return;
        }
        else
        {
            Console.WriteLine($"Simple goal '{_title}' completed!");
            user.AddPoints(_points);
            _isCompleted = true;   
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_title}, Description: {_description}, Points: {_points}, Completed: {_isCompleted}");
    }
}