using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("456 King St", "Toronto", "ON", "Canada");

        // Create customers
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Smith", addr2);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P1001", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 19.99, 2));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Desk Chair", "P2001", 149.99, 1));
        order2.AddProduct(new Product("Monitor", "P2002", 229.99, 2));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
