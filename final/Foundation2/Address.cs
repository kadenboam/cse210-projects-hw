class Address {
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public bool IsUSAAddress(string _country);
    public string GetAddress();
}