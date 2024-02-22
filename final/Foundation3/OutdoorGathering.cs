using System;

public class OutdoorGathering : Event
{
    protected string _weather;

    public OutdoorGathering (string eventType, string eventTitle, string eventDescription, string date, string time, string address, string weather) : base (eventType, eventTitle, eventDescription, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"Event Type: {GetEventType()}");
        Console.WriteLine(($"Event Title: {GetEventTitle()}"));
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Date and time: {GetDate()} - {GetTime()}");
        Console.WriteLine($"It will be {GetWeather()} during the event.");
        Console.WriteLine($"Address: {GetAddress()}");
    }

    public void DisplayOutdoorGathering()
    {
        DisplayStandardDetails();
        Console.WriteLine();
        DisplayFullDetails();
        Console.WriteLine();
        DisplayShortDetails();
    }
}