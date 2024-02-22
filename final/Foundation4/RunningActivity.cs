using System;

public class RunningActivity : Activity
{
    public RunningActivity(string activityType, string date, int minutes, double distance) : base (activityType, date, minutes, distance)
    {
    }

    public override double CalculateSpeed()
    {   
        double speed = GetDistance() / GetMinutes() * 60;
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }

    public void DisplayRunningActivity()
    {
        Console.WriteLine(GetSummary());
    }
}