using Microsoft.VisualBasic;

class Order {
    private List<Product> product = new List<Product>();
    Customer _customer = new Customer();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product newproduct)
    {
        product.Add(newproduct);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var price in product)
        {
            total += price.GetCost();
        }
        if (_customer.IsUSA()) { total -= 5.00; }
        return total;
    }
    public void PackageLabel()
    {
        foreach (var label in product)
        {
            Console.WriteLine(label.GetProduct());
        }
        Console.WriteLine();
    }
    public void ShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomer());
        Console.WriteLine();
    }
}