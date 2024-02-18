using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "LP100", 999.99, 1);
        Product product2 = new Product("Mouse", "MS200", 19.99, 2);
        Product product3 = new Product("Speakers", "S300", 79.99, 4);

        // Create addresses and customers
        Address address1 = new Address("123 Main St", "SanFran", "CA", "USA");
        Customer customer1 = new Customer("Jesus Paredes", address1);
        Address address2 = new Address("321 Principal St", "Manhattan", "NY", "USA");
        Customer customer2 = new Customer("Maria Castro", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing and shipping labels and total cost for the order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}");


        // Repeat the process for another order with different products and customer
        // ...

        // Wait for user input to close the console window
        Console.ReadLine();
    }
}