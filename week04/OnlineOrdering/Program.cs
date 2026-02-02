using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        Custumer custumer1 = new Custumer();
        Product product1 = new Product();
        Product product2 = new Product();
        Order order1 = new Order();

        address1.street = "123 Main Street";
        address1.city = "Anytown";
        address1.state = "CA";
        address1.country = "USA";
        address1.isUSAddress();
        
        custumer1.name = "John Doe";
        custumer1.address = address1;

        order1.custumer = custumer1;

        product1.addProduct("Laptop", "LP1001", 999.99, 1);
        product2.addProduct("Paper", "PP101", 25.00, 1);
        order1.products.Add(product1);
        order1.products.Add(product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.packingLabel());

        Console.WriteLine("Shipping Label:");
        order1.shippingLabel();
        
        Console.WriteLine($"\nTotal Order Price: ${order1.orderPrice()}\n");
        

        Address address2 = new Address();
        Custumer custumer2 = new Custumer();
        Product product3 = new Product();
        Product product4 = new Product();
        Order order2 = new Order();

        address2.street = "456 Oak Avenue";
        address2.city = "Somewhere";
        address2.state = "NY";
        address2.country = "Canada";
        address2.isUSAddress();
        
        custumer2.name = "Jane Smith";
        custumer2.address = address2;

        order2.custumer = custumer2;

        product3.addProduct("Keyboard", "KB1001", 99.99, 1);
        product4.addProduct("Clipper", "PP101", 6.00, 1);
        order2.products.Add(product3);
        order2.products.Add(product4);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.packingLabel());

        Console.WriteLine("Shipping Label:");
        order2.shippingLabel();
        
        Console.WriteLine($"\nTotal Order Price: ${order2.orderPrice()}\n");

    }
}