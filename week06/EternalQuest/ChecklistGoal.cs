using System;

public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int maxTimes;
    private int singleCompletionPoints;
    private int pointsToGive;

    public ChecklistGoal(string title, string description, int points, int maxTimes, int singleCompletionPoints)
        : base(title, description, points)
    {
        this.maxTimes = maxTimes;
        this.singleCompletionPoints = singleCompletionPoints;
        this.pointsToGive = 0;
        timesCompleted = 0;
    }

    public override void CompleteGoal(User user)
    {
        if (timesCompleted < maxTimes)
        {
            timesCompleted++;
            pointsToGive = singleCompletionPoints;
            Console.WriteLine($"Checklist goal '{_title}' completed {timesCompleted} time(s)!");
            user.AddPoints(pointsToGive);
        }
        else if (timesCompleted == maxTimes)
        {
            pointsToGive = _points;
            Console.WriteLine($"Checklist goal '{_title}' has reached its maximum completion limit. {pointsToGive} points will be awarded.");
            user.AddPoints(pointsToGive);
        }
        else 
        {
            Console.WriteLine($"Checklist goal '{_title}' has already been completed the maximum number of times.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_title}, Description: {_description}, Completed: {timesCompleted}/{maxTimes}, Single Completion Points: {singleCompletionPoints}, Final Completion Points: {_points}, Total Points Given: {pointsToGive}");
    }
}