class Address {
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUSAAddress()
    {
        if (_country == "USA" | _country == "united states" | _country == "united states of america" | _country == "US") { return true; }
        else { return false; }
    }

    public string GetAddress()
    {
        return $"Street: {_streetAddress}, City: {_city}, State or Province: {_stateOrProvince}, Country: {_country}";
    }
}