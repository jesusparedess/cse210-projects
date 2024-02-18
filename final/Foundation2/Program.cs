using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "LP100", 999.99, 1);
        Product product2 = new Product("Mouse", "MS200", 19.99, 2);

        // Create addresses and customers
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
    }
}