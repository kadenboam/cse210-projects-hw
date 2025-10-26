using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("");
        //Functions or reading files could have simplified all of this...

        //Defining the addresses
        Address adress1 = new Address("2020 Solara Loop NE", "Albuquerque", "New Mexico", "Mexico");
        Address adress2 = new Address("9485 Elmherst Dr.", "South Jordan", "Utah", "United states");

        //Then the customers
        Customer customer1 = new Customer("Henry", adress2);
        Customer customer2 = new Customer("Charles", adress2);
        Customer customer3 = new Customer("Andrew", adress1);

        //Next the Orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        //And the products to fill them
        Product product1 = new Product("Cheese", "AX36B9H2", 2.50, 5);
        Product product2 = new Product("Milk", "P7TV5R3", 4.30, 1);
        Product product3 = new Product("Apples", "B87YX93D", 2.00, 10);

        Product product4 = new Product("Nail", "J5H4B65G", 4.50, 3);
        Product product5 = new Product("Cup", "F3N86B87P", 15, 1);
        Product product6 = new Product("Spoon", "L7MYN67R", 5.00, 2);

        //Adding products to orders
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        order3.AddProduct(product2);
        order3.AddProduct(product5);
        order3.AddProduct(product6);

        //Order 1
        order1.PackageLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Total cost: {order1.CalculateTotal()}");
        Console.WriteLine();
        Console.WriteLine("---------------");

        //Order 2
        order2.PackageLabel();
        order2.ShippingLabel();
        Console.WriteLine($"Total cost: {order2.CalculateTotal()}");
        Console.WriteLine();
        Console.WriteLine("---------------");

        //Order 3
        order3.PackageLabel();
        order3.ShippingLabel();
        Console.WriteLine($"Total cost: {order3.CalculateTotal()}");
        Console.WriteLine();
        Console.WriteLine("---------------");
    }
}