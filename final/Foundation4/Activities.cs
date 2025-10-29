using System.Diagnostics;

abstract class Activities {
    protected string _date;
    protected double _minutes;

    public Activities(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance(int dontWrite);
    public abstract double Speed();
    public abstract double Pace();
    public string GetSummary()
    {
        Distance(0);
        Speed();
        Pace();
        Console.WriteLine();
        return $"";
    }
}