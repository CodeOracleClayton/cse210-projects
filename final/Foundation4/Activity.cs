using System;

public class Activity
{
    private string _activityType;
    private string _date;
    private int _minutes;
    private double _distance;

    public Activity()
    {
    }

    public Activity (string activityType, string date, int minutes, double distance)
    {
        _activityType = activityType;
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }

    public virtual string GetActivityType()
    {
        return _activityType;
    }

    public virtual string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetMinutes()
    {
        return _minutes;
    }

    public string GetSummary()
    {
        if (_activityType == "Swimming")
        {
            return $"{_date} {GetActivityType()} ({_minutes} min): Distance {GetDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} meter per mile)";
        }

        else
        {
            return $"{_date} {GetActivityType()} ({_minutes} min): Distance {GetDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile)";
        }
    }
    
    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }
}