class SimpleGoal : Goal {
    private bool _isCompleted;

    //This is for knowing what class they are after pulling from a list in program
    public string type = "s";

    public SimpleGoal() { }
    public SimpleGoal(int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary)
    {
        _isCompleted = false;
    }

    //Sets basic goal parameters as well as if the goal is completed
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
    public override void DisplayGoal()
    {
        Console.WriteLine("");
        string xMark = " ";
        if (_isCompleted) { xMark = "X"; }
        Console.WriteLine($"[{xMark}] {_goalName}, {_goalSummary} ");
    }
}