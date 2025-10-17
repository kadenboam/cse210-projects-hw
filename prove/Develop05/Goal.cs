public abstract class Goal {
    private int _earnPoints;
    private int _totalPoints;
    protected string _goalName;
    protected string _goalSummary;

    public abstract void AddPoints();
    public abstract void SetGoal(int earnPoints, string goalName, string goalSummary);
    public abstract void DisplayGoal(string goalName, string goalSummary, int totalPoints);
}