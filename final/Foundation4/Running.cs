class Running : Activities {
    private double _distance;

    public Running(double distance, string date, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance(int dontWrite)
    {
        if (dontWrite != 1)
        {
            Console.WriteLine($"The Running distance is: {_distance} Km");
        }
        return _distance;
    }
    public override double Speed()
    {
        double speed = (Distance(1) / _minutes) * 60;
        Console.WriteLine($"The Running Speed is: {speed} Km/hour");
        return speed;
    }
    public override double Pace()
    {
        double pace = _minutes/Distance(1);
        Console.WriteLine($"The Running pace is: {pace} minutes per Km");
        return pace;
    }
}