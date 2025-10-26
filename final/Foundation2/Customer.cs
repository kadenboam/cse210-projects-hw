class Customer {
    private string _name;
    Address _address = new Address();

    public Customer(){}
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
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