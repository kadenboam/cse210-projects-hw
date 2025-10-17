using System.Globalization;
using System.Numerics;

public abstract class Goal
{
    protected int _earnPoints;
    protected string _goalName;
    protected string _goalSummary;

    //Initializers for Goal class
    public Goal() { }

    public Goal(int earnPoints, string goalName, string goalSummary)
    {
        _earnPoints = earnPoints;
        _goalName = goalName;
        _goalSummary = goalSummary;
    }

    //Functions to be called by the other classes to set the total points in the program
    public int AddPoints(int totalPoints)
    {
        totalPoints += _earnPoints;
        return totalPoints;
    }
    public int AddPoints(int bonusPoints, int totalPoints)
    {
        totalPoints += _earnPoints;
        totalPoints += bonusPoints;
        return totalPoints;
    }

    //Function used in each class to set the similar Goal asspects
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

    //A function to be over written in each of the other classes
    public abstract void DisplayGoal();

    //A function to be used in the other classes to check user input if it is integer compadible
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