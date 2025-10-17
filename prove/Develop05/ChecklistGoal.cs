public class ChecklistGoal : Goal {
    private int _repeatTimes;
    private int _completedTimes;
    private int _bonusPoints;

    //This is for knowing what class they are after pulling from a list in program
    public string type = "c";

    //Checklist Goal initializers
    public ChecklistGoal() { }
    public ChecklistGoal(int repeatTimes, int bonusPoints, int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary)
    {
        _repeatTimes = repeatTimes;
        _completedTimes = 0;
        _bonusPoints = bonusPoints;
    }

    //Used to set the checklistGoal
    public void SetChecklistGoal()
    {
        SetGoal();
        Console.WriteLine("");
        Console.Write("How many times should it be repeated? ");
        _repeatTimes = CheckInt();
        Console.WriteLine("");
        Console.Write("How many extra points will you get? ");
        _bonusPoints = CheckInt();
    }
    public void AddBonusPoints()
    {
        AddPoints(_bonusPoints);
    }
    public override void DisplayGoal()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_goalName}, {_goalSummary}, {_completedTimes}/{_repeatTimes}");
    }
}