public class ChecklistGoal : Goal {
    private int _repeatTimes;
    private int _completedTimes;
    private int _bonusPoints;


    //Checklist Goal initializers
    public ChecklistGoal() { }
    public ChecklistGoal(int repeatTimes, int completedTimes, int bonusPoints, int earnPoints, string goalName, string goalSummary) : base(earnPoints, goalName, goalSummary)
    {
        _repeatTimes = repeatTimes;
        _completedTimes = completedTimes;
        _bonusPoints = bonusPoints;
    }

    //Used to set the checklistGoal
    public void SetChecklistGoal()
    {
        SetGoal();
        Console.WriteLine("");
        Console.Write("How many times should it be repeated? ");
        _repeatTimes = CheckInt();
        Console.Write("How many extra points will you get? ");
        _bonusPoints = CheckInt();
    }
    public override int AddPoints(int totalPoints)
    {
        if (_completedTimes < (_repeatTimes - 1))
        {
            totalPoints += _earnPoints;
            _completedTimes += 1;
        }
        else if (_completedTimes < _repeatTimes)
        {
            totalPoints += _earnPoints;
            totalPoints += _bonusPoints;
        }
        Console.WriteLine($"Congragulations! You now have {totalPoints}! ");
        return totalPoints;
    }

    public override string DisplayGoal(int consoleWrite)
    {
        if (consoleWrite == 1)
        {
            string xMark = " ";
            if (_completedTimes >= _repeatTimes) { _xMark = "X"; }
            Console.WriteLine($"[{xMark}] {_goalName} ({_goalSummary}) {_completedTimes}/{_repeatTimes}");
        }
        return $"{_goalName},{_goalSummary},{_completedTimes},{_repeatTimes},{_bonusPoints},{_earnPoints}";
    }
}