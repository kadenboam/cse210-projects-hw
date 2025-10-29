class Running : Activities {
    private double _distance;

    public Running(double distance, string date, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return (Distance()/_minutes) * 60;
    }
    public override double Pace()
    {
        return _minutes/Distance();
    }
}