class OutdoorGatherings : Events {
    private string _weather;

   public OutdoorGatherings(string eventTitle, string description, string date, int time, string weather) : base(eventTitle, description, date, time)
    {
        _weather = weather;
    }


    public string DisplayOutdoorGathering(string address)
    {
        return DisplayEvent(address) + $", Weather: {_weather}";
    }
}
