using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Springfield", "IL", "USA");
        Address internationalAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Joseph Adams", usaAddress);
        Customer customer2 = new Customer("Aaliyah Raniel", internationalAddress);

        // Create products
        Product product1 = new Product("Widget", "A123", 10.99m, 2);
        Product product2 = new Product("Gadget", "B456", 5.49m, 4);
        Product product3 = new Product("Doohickey", "C789", 12.75m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
    }
}
