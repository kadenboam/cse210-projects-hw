using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Running running1 = new Running(0.5 /*Km*/, "10/30/2025", 5.5);
        StationaryBicycle bike1 = new StationaryBicycle(10 /*Km/hr*/, "11/06/2025", 7.8);
        Swiming swim1 = new Swiming(12, "10/28/2025", 20.5);

        running1.Distance();
        running1.Speed();
        running1.Pace();

        
    }
}