public class ChecklistGoal : Goal {
    private int _repeatTimes;
    private int _completedTimes;
    private int _bonusPoints;

    public ChecklistGoal(int repeatTimes, int bonusPoints, int earnPoints, int totalPoints, string goalName, string goalSummary) : base(earnPoints, totalPoints, goalName, goalSummary)
    {
        _repeatTimes = repeatTimes;
        _completedTimes = 0;
        _bonusPoints = bonusPoints;
    }

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
    public override void DisplayGoal(string goalName, string goalSummary, int totalPoints)
    {
        //, int repeatTimes, int completedTimes
    }
}