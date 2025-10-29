class Running : Activities {
    private double _distance;

    public Running(double distance, string date, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance(double distance)
    {
        return _distance;
    }
    public override double Speed(double minutes)
    {
        return (Distance(_distance)/minutes) * 60;
    }
    public override double Pace(double _minutes)
    {
        return _minutes/Distance(_distance);
    }
}