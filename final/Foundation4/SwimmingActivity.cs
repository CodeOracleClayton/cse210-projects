using System;

public class SwimmingActivity : Activity
{
    private int _numOfLaps;
    public SwimmingActivity(string activityType, string date, int minutes, double distance, int numOfLaps) : base (activityType, date, minutes, distance)
    {
        _numOfLaps = numOfLaps;
    }

    public int GetNumOfLaps()
    {   
        return _numOfLaps;
    }

    public override double GetDistance()
    {
        double numOfLaps = _numOfLaps * 50 / 1000;
        return numOfLaps;
    }

    public override double CalculateSpeed()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double CalculatePace()
    {
        double pace = GetMinutes() / GetDistance() * 60;
        return pace;
    }

    public void DisplaySwimmingActivity()
    {
        Console.WriteLine(GetSummary());
    }
}