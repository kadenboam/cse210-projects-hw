class Lectures : Events{
    private int _capacity;
    private string _speaker;

    public Lectures(string eventTitle, string description, string date, int time, int capacity, string speaker) : base(eventTitle, description, date, time)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    public string DisplayLecture(string address)
    {
        return DisplayEvent(address) + $", Speaker: {_speaker}, Capacity: {_capacity}";
    }
}
