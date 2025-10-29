abstract class Activities {
    protected string _date;
    protected double _minutes;

    public Activities(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance(double theDistance);
    public abstract double Speed(double minutes);
    public abstract double Pace(double minutes);
    public string GetSummary()
    {
        return $" ";
    }
}