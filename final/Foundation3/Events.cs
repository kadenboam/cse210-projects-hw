abstract class Events {
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected int _time;
    protected string _address;

    public string DisplayEvent()
    {
        return $"Event: {_eventTitle}, {_description}, Date: {_time} on {_date} at {_address}";
    }
    public void DisplaySimple(string eventType)
    {
        Console.WriteLine($"Event Type: {eventType}, Event: {_eventTitle}, Date: {_date}");
    }
}