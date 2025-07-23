using System;

public class User
{
    private string _name;
    private int _totalPoints;
    protected List<Goal> _goals = new List<Goal>();


    public User(string name)
    {
        _name = name;
        _totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.GetTitle()}' added for user '{_name}'.");
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public string GetName()
    {
        return _name;
    }



    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        Console.WriteLine($"User '{_name}' now has {_totalPoints} total points.");
    }


}
