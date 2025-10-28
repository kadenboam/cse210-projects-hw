class StationaryBicycle : Activities {
    private double _speed;

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