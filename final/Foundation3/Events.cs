abstract class Events {
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected int _time;

    public Events(string eventTitle, string description, string date, int time)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
    }

    public string DisplayEvent(string address)
    {
        return $"Event: {_eventTitle}, {_description}, Date: {_time} on {_date} at {address}";
    }
    public void DisplaySimple(string eventType)
    {
        Console.WriteLine($"Event Type: {eventType}, Event: {_eventTitle}, Date: {_date}");
    }
}