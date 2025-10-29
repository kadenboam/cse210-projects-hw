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

        Console.WriteLine($"The Running distance is: {running1.Distance()} Km");
        Console.WriteLine($"The Running Speed is: {running1.Speed()} Km/hour");
        Console.WriteLine($"The Running pace is: {running1.Pace()} minutes per Km");
        Console.WriteLine();

        Console.WriteLine($"The Biking distance is: {bike1.Distance()} Km");
        Console.WriteLine($"The Biking speed is: {bike1.Speed()} Km/hour");
        Console.WriteLine($"The Biking pace is: {bike1.Pace()} minutes per Km");
        Console.WriteLine();

        Console.WriteLine($"The Swiming distance is: {swim1.Distance()} Km");
        Console.WriteLine($"The Swiming speed is: {swim1.Speed()} Km/hour");
        Console.WriteLine($"The Swiming pace is: {swim1.Pace()} minutes per Km");
        Console.WriteLine();

    }
}