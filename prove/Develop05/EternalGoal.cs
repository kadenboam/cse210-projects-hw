class EternalGoal : Goal{
    //All of the values needed for this class are already in Goal class

    //This is for knowing what class they are after pulling from a list in program
    public string type = "e";

    public EternalGoal() { }
    public EternalGoal(int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary) { }

    public void SetEternalGoal()
    {
        SetGoal();
    }
    public override void DisplayGoal()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_goalName}, {_goalSummary}");
    }
}