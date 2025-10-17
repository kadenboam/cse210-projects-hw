class SimpleGoal : Goal {
    private bool _isCompleted;

    public SimpleGoal(int earnPoints, int totalPoints, string goalName, string goalSummary) : base(earnPoints, totalPoints, goalName, goalSummary)
    {
        _isCompleted = false;
    }

    public void SetSimpleGoal()
    {
        SetGoal();
        _isCompleted = false;
    }
    public void SetSimpleGoal(bool check)
    {
        SetGoal();
        _isCompleted = check;
    }
    public override void DisplayGoal(string goalName, string goalSummary, int totalPoints)
    {
        Console.WriteLine("");
    }
}