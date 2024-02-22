//Clayton Zulu - Foundation 4

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity activity1 = new RunningActivity("Running", "Februry 29, 2024", 30, 3.0);
        CyclingActivity activity2 = new CyclingActivity("Cycling", "Februry 29, 2024", 30, 15, 20);
        SwimmingActivity activity3 = new SwimmingActivity("Swimming", "Februry 29, 2024", 30, 10, 60);;

        activities.Add(activity1);
        activities.Add(activity2);
        activities.Add(activity3);

        Console.WriteLine();
        Console.WriteLine("Exercise Tracking:");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}