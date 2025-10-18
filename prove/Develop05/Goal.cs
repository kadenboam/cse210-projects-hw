using System.Globalization;
using System.Numerics;

public abstract class Goal
{
    protected int _earnPoints;
    protected string _goalName;
    protected string _goalSummary;
    protected string _xMark = " ";
    public string type;

    //Initializers for Goal class
    public Goal() { }

    public Goal(int earnPoints, string goalName, string goalSummary)
    {
        _earnPoints = earnPoints;
        _goalName = goalName;
        _goalSummary = goalSummary;
    }

    //Functions to be called by the other classes to set the total points in the program
    public abstract int AddPoints(int totalPoints);

    //Function used in each class to set the similar Goal asspects
    public void SetGoal()
    {
        Console.Write("What is your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of this goal? ");
        _goalSummary = Console.ReadLine();
        Console.Write("How many point will you earn for completing this goal? ");
        _earnPoints = CheckInt();
    }

    //A function to be over written in each of the other classes
    public abstract string DisplayGoal(int consoleWrite);

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

    public string GetXMark(){ return _xMark; }
}