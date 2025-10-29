class Swiming : Activities{
    private double _numberOfLaps;

    public Swiming(double numberOfLaps, string date, double minutes) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance(int dontWrite)
    {
        double distance = _numberOfLaps * 50 / 1000;
        if (dontWrite != 1)
        {
            Console.WriteLine($"The Swiming distance is: {distance} Km");
        }  
        return distance;
    }
    public override double Speed()
    {
        double speed = (Distance(1) / _minutes) * 60;
        Console.WriteLine($"The Swiming speed is: {speed} Km/hour");
        return speed;
    }
    public override double Pace()
    {
        double pace = _minutes / (Distance(1));
        Console.WriteLine($"The Swiming pace is: {pace} minutes per Km");
        return pace;
        //or return minutes / Distance();
    }
}