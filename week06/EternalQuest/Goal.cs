using System;

public class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
   


    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_title}, Description: {_description}, Points: {_points}");
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual void CompleteGoal(User user)
    {
        GiveUserPoints(user);
        Console.WriteLine($"Goal '{_title}' completed!");
    }
    public virtual void GiveUserPoints(User user)
    {
        user.AddPoints(_points);
    }
}