class EternalGoal : Goal{

    public EternalGoal(int earnPoints, int totalPoints, string goalName, string goalSummary) : base(earnPoints, totalPoints, goalName, goalSummary){}

    public void SetEternalGoal()
    {
        SetGoal();
    }
    public override void DisplayGoal(string goalName, string goalSummary, int totalPoints)
    {
        
    }
}