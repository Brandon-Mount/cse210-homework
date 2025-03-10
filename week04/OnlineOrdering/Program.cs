using System;

class Program
{
    static void Main(string[] args)
    {
         Customer customer1 = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 1200, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25, 2));
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "T789", 300, 1));
        order2.AddProduct(new Product("Keyboard", "K321", 50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}