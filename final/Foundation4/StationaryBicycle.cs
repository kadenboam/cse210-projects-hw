class StationaryBicycle : Activities {
    private double _speed;

    public StationaryBicycle(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance(double minutes)
    {
        return _speed * minutes;
    }
    public override double Speed(double _minutes)
    {
        return _speed;
    }
    public override double Pace(double minutes)
    {
        return minutes / Distance(minutes);
    }
}