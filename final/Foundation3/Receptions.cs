class Receptions : Events{
    private string _rsvpEmail;

    public Receptions(string eventTitle, string description, string date, int time, string rsvp) : base(eventTitle, description, date, time)
    {
        _rsvpEmail = rsvp;
    }

    public string DisplayReception(string address)
    {
        return DisplayEvent(address) + $", RSVP: {_rsvpEmail}";
    }
}