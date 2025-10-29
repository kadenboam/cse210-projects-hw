using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();


        Running running1 = new Running(0.5 /*Km*/, "10/30/2025", 5.5);
        StationaryBicycle bike1 = new StationaryBicycle(10 /*Km/hr*/, "11/06/2025", 7.8);
        Swiming swim1 = new Swiming(4, "10/28/2025", 5.75);

        List<Activities> activities = new List<Activities>();
        activities.Add(running1);
        activities.Add(bike1);
        activities.Add(swim1);

        foreach(var activity in activities)
        {
            activity.GetSummary();
        }
    }
}