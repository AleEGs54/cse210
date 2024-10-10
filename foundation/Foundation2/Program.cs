using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(name: "Joe Doe", address: "123 S Main St, Salt Lake City, Utah, US");
        order1.AddProduct("Macbook Air M2 16GB 512GB", 432345424, 1099.98f, 1);
        order1.AddProduct("iPhone 11 64GB", 097346796, 599.99f, 1);
        order1.AddProduct("Earbuds Pro 2", 257833927, 129.98f, 2);


        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.OrderTotalCost());
        Console.WriteLine("----------------------------------");

        Order order2 = new Order(name: "Alex Milkman", address: "123 George Street, Sydney, NSW 2000, Australia");
        order2.AddProduct("Stainless Steel Water Bottle", 837462015, 89.99f, 3);
        order2.AddProduct("Bluetooth Speaker", 102984376, 599.99f, 1);
        order2.AddProduct("Smartwatch", 758203641, 129.98f, 2);


        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.OrderTotalCost());
        Console.WriteLine("----------------------------------");

        Order order3 = new Order(name: "Hanna Montana", address: "123 Rua da Consolação, São Paulo, SP 01301-100, Brazil");
        order3.AddProduct("Laptop Stand", 903714286, 24.99f, 1);
        order3.AddProduct("Gaming Mouse", 564382019, 35.50f, 1);
        order3.AddProduct("Wireless Earbuds", 482736159, 49.99f, 2);


        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine(order3.OrderTotalCost());
        Console.WriteLine("----------------------------------");

    }
}