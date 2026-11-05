using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(
            new Product("Laptop", "P100", 800, 1));

        order1.AddProduct(
            new Product("Mouse", "P101", 25, 2));

        order1.AddProduct(
            new Product("Keyboard", "P102", 50, 1));

        // ORDER 2 (International)

        Address address2 = new Address(
            "45 Avenue de la Paix",
            "Brazzaville",
            "Brazzaville",
            "Congo");

        Customer customer2 = new Customer(
            "Yavich Soundat",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(
            new Product("Smartphone", "P200", 600, 1));

        order2.AddProduct(
            new Product("Case", "P201", 20, 2));

        order2.AddProduct(
            new Product("Charger", "P202", 30, 1));

        // DISPLAY ORDER 1

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine();

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine();

        // DISPLAY ORDER 2

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine();

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}