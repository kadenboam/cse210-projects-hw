class EternalGoal : Goal{

    public EternalGoal() { }
    public EternalGoal(int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary) { }

    public void SetEternalGoal()
    {
        SetGoal();
    }
    public override void DisplayGoal(string goalName, string goalSummary, int totalPoints)
    {
        
    }
}