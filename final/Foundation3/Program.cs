//Clayton Zulu - Foundation 3

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for the events
        Lecture event1 = new Lecture("Lecture", "Ace Lumumba", "Ace will give us a brief history of the struggle that he faced.", "Feb 29, 2024", "18:00", "1210 Chumba Street, GWE. 054", "Ace Lumumba", 100);
        Reception event2 = new Reception("Reception", "Wedding of Tonie and Lavie", "Congratulations Tonie and Lavie for getting sealed for time and eternity!", "March 02, 2024", "09:00", "Cnr Turvey & Woburn, Benoni, SA. 1501", "claytonzulu1210@gmail.com");
        OutdoorGathering event3 = new OutdoorGathering("Outdoor Gathering", "YSA Hike", "Come and join us to as we get to know each other!", "April 06, 2024", "15:00", "Benoni Chapel , SA. 1501", "sunny");

        // Call the methods from the instances that was created
        event1.DisplayLecture();
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        event2.DisplayReception();
        Console.WriteLine();
        Console.WriteLine("------------------------");
        Console.WriteLine();

        event3.DisplayOutdoorGathering();
        Console.WriteLine();

    }
}
