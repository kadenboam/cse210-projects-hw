using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        EternalGoal start = new EternalGoal(100, "Yes", "summary");
        EternalGoal start2 = new EternalGoal(200, "Yes", "summary");
        List<Goal> GoalList = new List<Goal>();
        Console.WriteLine(totalPoints);
        totalPoints = start.AddPoints(totalPoints);
        Console.WriteLine(totalPoints);
        totalPoints = start2.AddPoints(totalPoints);
        Console.WriteLine(totalPoints);
    }
}