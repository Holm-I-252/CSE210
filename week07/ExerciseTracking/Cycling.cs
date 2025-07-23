using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int duration, DateTime date, double speed) : base(duration, date)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60.0);
    }

    public override double GetPace()
    {
        return (GetDuration() / 60.0) / GetDistance();
    }
    
    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Cycling ({GetDuration()} min) Distance: {GetDistance()} km, Speed: {_speed:F2} km/h, Pace: {GetPace():F2} min/km.";
    }
}