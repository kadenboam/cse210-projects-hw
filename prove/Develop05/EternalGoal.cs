class EternalGoal : Goal{
    //All of the values needed for this class are already in Goal class

    public EternalGoal() { }
    public EternalGoal(int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary) { }

    public void SetEternalGoal()
    {
        SetGoal();
    }
    public override int AddPoints(int totalPoints)
    {
        totalPoints += _earnPoints;
        return totalPoints;
    }
    public override string DisplayGoal(int consoleWrite)
    {
        if (consoleWrite == 1)
        {
            Console.WriteLine($"[ ] {_goalName} ({_goalSummary})");
        }
        return $"{_goalName}, {_goalSummary},{_earnPoints}";

    }
}