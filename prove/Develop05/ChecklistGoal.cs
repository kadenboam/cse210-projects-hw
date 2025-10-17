public class ChecklistGoal : Goal {
    private int _repeatTimes;
    private int _completedTimes;
    private int _bonusPoints;

    public ChecklistGoal(int repeatTimes, int completedTimes, int bonusPoints, int earnPoints, int totalPoints, string goalName, string goalSummary) : base(earnPoints, totalPoints, goalName, goalSummary)
    {
        _repeatTimes = repeatTimes;
        _completedTimes = completedTimes;
        _bonusPoints = bonusPoints;
    }

    public void SetChecklistGoal()
    {
        SetGoal(_earnPoints, _goalName, _goalSummary);

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