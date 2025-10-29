class Swiming : Activities{
    private double _numberOfLaps;

    public override double Distance(double numberOfLaps)
    {
        return _numberOfLaps * 50 / 1000;
    }
    public override double Speed(double minutes)
    {
        return (_numberOfLaps * 50 / minutes) * 60;

    }
    public override double Pace(double minutes)
    {
        return minutes / (_numberOfLaps * 50);
        //or return minutes / Distance();
    }
}