using System.Globalization;
using System.Numerics;

public abstract class Goal {
    protected int _earnPoints;
    private int _totalPoints;
    protected string _goalName;
    protected string _goalSummary;

    public Goal(int earnPoints, int totalPoints, string goalName, string goalSummary)
    {
        _earnPoints = earnPoints;
        _totalPoints = totalPoints;
        _goalName = goalName;
        _goalSummary = goalSummary;
    }

    public void AddPoints()
    {
        _totalPoints += _earnPoints;
    }
    public void AddPoints(int bonusPoints)
    {
        _totalPoints += _earnPoints;
        _totalPoints += bonusPoints;
    }
    
    public void SetGoal()
    {
        Console.WriteLine("");
        Console.Write("What is your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description of this goal? ");
        _goalSummary = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("How many point will you earn for completing this goal? ");
        _earnPoints = CheckInt();
    }
    public abstract void DisplayGoal(string goalName, string goalSummary, int totalPoints);

    public int CheckInt()
    {
        string input = Console.ReadLine();
        int number;
        //Double checks compatability
        while (!int.TryParse(input, out number))
        {
            Console.Write("Invalid input. Please enter a number: ");
            input = Console.ReadLine();
        }
        return number;
    }
}