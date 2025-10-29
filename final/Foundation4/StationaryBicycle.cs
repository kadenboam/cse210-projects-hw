using System.Diagnostics;

class StationaryBicycle : Activities {
    private double _speed;

    public StationaryBicycle(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * _minutes;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return _minutes / Distance();
    }
}