using System;

public class Running : Activity
{
    private double _distance;

    public Running(int duration, DateTime date, double distance) : base(duration, date)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (GetDuration() / 60.0);
    }

    public override double GetPace()
    {
        return (GetDuration() / 60.0) / _distance;
    }
    
    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Running ({GetDuration()} min) Distance: {GetDistance()} km, Speed: {GetSpeed():F2} km/h, Pace: {GetPace():F2} min/km.";
    }
}