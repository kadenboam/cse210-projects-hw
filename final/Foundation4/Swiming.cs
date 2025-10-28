class Swiming : Activities{
    private double _numberOfLaps;

    public override double Distance(double numberOfLaps)
    {
        return _numberOfLaps * 50;
    }
    public override double Speed(double minutes)
    {
        return _numberOfLaps * 50 / minutes;

    }
    public override double Pace(double minutes)
    {
        return minutes / (_numberOfLaps * 50);
    }
}