using System;

public class Activity
{
    private int _duration;
    private DateTime _date;

    public Activity(int duration, DateTime date)
    {
        _duration = duration;
        _date = date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public virtual double GetSpeed()
    {
        return 0.0; 
    }

    public virtual double GetPace()
    {
        return 0.0; 
    }

    public virtual double GetDistance()
    {
        return 0.0; 
    }

    public virtual string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} for {GetDuration()} minutes.";
    }
}