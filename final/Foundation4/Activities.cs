abstract class Activities {
    protected string _date;
    protected double _minutes;

    public abstract double Distance(double theDistance);
    public abstract double Speed(double _minutes);
    public abstract double Pace(double _minutes);
    public string GetSummary()
    {
        return $"";
    }
}