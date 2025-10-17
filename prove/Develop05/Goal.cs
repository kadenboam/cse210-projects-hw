public abstract class Goal {
    protected int _earnPoints;
    private int _totalPoints;
    protected string _goalName;
    protected string _goalSummary;

    public Goal(int earnPoints, int totalPoints, string goalName, string goalSummary)
    {
        _earnPoints = earnPoints;
        _totalPoints = totalPoints;
        _goalName = goalName;
        _goalSummary = goalSummary;
    }

    public void AddPoints()
    {
        _totalPoints += _earnPoints;
    }
    public void AddPoints(int bonusPoints)
    {
        _totalPoints += _earnPoints;
        _totalPoints += bonusPoints;
    }
    
    public void SetGoal(int earnPoints, string goalName, string goalSummary)
    {
        _earnPoints = earnPoints;
        _goalName = goalName;
        _goalSummary = goalSummary;
    }
    public abstract void DisplayGoal(string goalName, string goalSummary, int totalPoints);
}