abstract class Activities {
    protected string _date;
    protected double _minutes;

    public abstract double Distance(double theDistance);
    public abstract double Speed(double minutes);
    public abstract double Pace(double minutes);
    public string GetSummary()
    {
        return $" ";
    }
}