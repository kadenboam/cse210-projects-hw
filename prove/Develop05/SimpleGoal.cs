class SimpleGoal : Goal {
    private bool _isCompleted;

    public SimpleGoal() { }
    public SimpleGoal(string isCompleted, int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary)
    {
        if (isCompleted == "True") { _isCompleted = true; }
        else { _isCompleted = false; }
    } 

    //Sets basic goal parameters as well as if the goal is completed
    public void SetSimpleGoal()
    {
        SetGoal();
    }

    public void SetCompleted()
    {
        _isCompleted = true;
    }
    public override int AddPoints(int totalPoints)
    {
        totalPoints += _earnPoints;
        return totalPoints;
    }

    public override string DisplayGoal(int consoleWrite)
    {
        if (consoleWrite == 1){
            if (_isCompleted) { _xMark = "X"; }
            Console.WriteLine($"[{_xMark}] {_goalName} ({_goalSummary}) ");
        }
        return $"{_isCompleted},{_goalName},{_goalSummary},{_earnPoints}";

    }
}