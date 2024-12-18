using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new RunningActivity("03 Nov 2022", 30, 4.8),
            new CyclingActivity("03 Nov 2022", 60, 21.5),
            new SwimmingActivity("03 Nov 2022", 45, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}