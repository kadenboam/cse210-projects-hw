using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        //Simple test of Assignment class
        Assignment a1 = new Assignment("Henry Beckett", "Physics");
        Console.WriteLine(a1.GetSummary());
    }
}