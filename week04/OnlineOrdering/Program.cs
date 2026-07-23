using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Edward Styles", new Address("20 Tanza Rd", "Hampstead Heath", "London", "UK"));
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Watch", "0936471", 200.00, 1));
        products1.Add(new Product("Vase", "029175", 80.00, 2));
        products1.Add(new Product("Cushion Grey", "029361", 19.99, 6));
        Order order1 = new Order(customer1, products1);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Shipped to: {order1.GetShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"Total Price: {order1.TotalCost()}");
        Console.WriteLine("Products:");
        Console.WriteLine(order1.GetPackagingLabel());

        Customer customer2 = new Customer("Claudia Eilish", new Address("630 Elm Dr", "Beverly Hills", "California", "USA"));
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Couch", "093761", 2500.00, 1));
        products2.Add(new Product("Kitchen Stool", "087351", 60, 4));
        products2.Add(new Product("Curtain", "0639142", 180.00, 2));
        Order order2 = new Order(customer2, products2);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Shipped to: {order2.GetShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"Total Price: {order2.TotalCost()}");
        Console.WriteLine("Products:");
        Console.WriteLine(order2.GetPackagingLabel());
    }
}