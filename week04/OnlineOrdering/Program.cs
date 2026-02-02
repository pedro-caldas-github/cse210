class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        
        order1.AddProduct(new Product("Laptop", "LP100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        Address addr2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Jane Smith", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Keyboard", "KB50", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MN10", 150.00, 1));

        List<Order> orders = new List<Order> { order1, order2 };
        int count = 1;

        foreach (Order o in orders)
        {
            Console.WriteLine($"--- ORDER {count} ---");
            Console.WriteLine("PACKING LABEL:");
            Console.WriteLine(o.GetPackingLabel());
            
            Console.WriteLine("SHIPPING LABEL:");
            Console.WriteLine(o.GetShippingLabel());
            
            Console.WriteLine($"TOTAL PRICE: ${o.CalculateTotalOrderPrice():F2}");
            Console.WriteLine();
            count++;
        }
    }
}