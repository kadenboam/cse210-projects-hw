class Swiming : Activities{
    private double _numberOfLaps;

    public Swiming(double numberOfLaps, string date, double minutes) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }
    public override double Speed()
    {
        return (_numberOfLaps * 50 / _minutes) * 60;

    }
    public override double Pace()
    {
        return _minutes / (_numberOfLaps * 50);
        //or return minutes / Distance();
    }
}