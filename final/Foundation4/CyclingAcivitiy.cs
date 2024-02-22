using System;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string activityType, string date, int minutes, double distance, double speed) : base (activityType, date, minutes, distance)
    {
        _speed = speed;
    }




    public double GetSpeed()
    {   
        return _speed;
    }

    public override double CalculateSpeed()
    {
        double speed = 60 / CalculatePace();
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = 60.0 / GetSpeed();
        return pace;
    }

    public void DisplayCyclingActivity()
    {
        Console.WriteLine(GetSummary());
    }
}