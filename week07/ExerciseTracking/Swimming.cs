using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(int duration, DateTime date, double laps) : base(duration, date)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        return _laps * 50; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration();
    }

    public override double GetPace()
    {
        return GetDuration() / _laps;
    }
    
    public override string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} Swimming ({GetDuration()} min) Distance: {GetDistance()} m, Speed: {GetSpeed():F2} m/min, Pace: {GetPace():F2} min/lap.";
    }
}