class Customer {
    private string _name;
    Address _address = new Address();

    public void SetCustomer(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        _name = name;
        _address.SetAddress(streetAddress, city, stateOrProvince, country);
    }
    public string GetCustomer()
    {
        return $"{_name}, {_address.GetAddress()}";
    }
    public bool IsUSA()
    {
        return _address.IsUSAAddress();
    }
}