class Product {
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }
    public string GetProduct()
    {
        return $"Product Name: {_name}, Product Id: {_productId}";
    }
    public double GetCost()
    {
        return _pricePerUnit * _quantity;
    }
}