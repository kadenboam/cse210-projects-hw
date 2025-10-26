class Order {
    private List<Product> product = new List<Product>();
    Customer customer = new Customer();

    public Order(string name, string streetAddress, string city, string stateOrProvince, string country)
    {
        customer.SetCustomer(name, streetAddress, city, stateOrProvince, country);
    }

    public void AddProduct(string name, string productId, double pricePerUnit, int quantity)
    {
        product.Add(new Product(name, productId, pricePerUnit, quantity));
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var price in product)
        {
            total += price.GetCost();
        }
        return total;
    }
    public void PackageLabel()
    {
        foreach (var label in product)
        {
            Console.WriteLine(label.GetProduct());
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine(customer.GetCustomer());
    }
}