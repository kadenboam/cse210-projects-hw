class Order {
    private List<Product> product = new List<Product>();
    private List<Customer> customers = new List<Customer>();

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
        foreach (var label in customers)
        {
            Console.WriteLine(label.GetCustomer());
        }
    }
}