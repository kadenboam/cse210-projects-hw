using System.Diagnostics;

class StationaryBicycle : Activities {
    private double _speed;

    public StationaryBicycle(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance(int dontWrite)
    {
        double distance = _speed * _minutes;
        if (dontWrite != 1)
        {
            Console.WriteLine($"The Biking distance is: {distance} Km");
        }
        return distance;
    }
    public override double Speed()
    {
        Console.WriteLine($"The Biking speed is: {_speed} Km/hour");
        return _speed;
    }
    public override double Pace()
    {
        double pace = _minutes / Distance(1);
        Console.WriteLine($"The Biking pace is: {pace} minutes per Km");

        return pace;
    }
}