public class Order
{
    public Custumer custumer;
    public List<Product> products = new List<Product>();

    public double orderPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.totalPrice();
        }

        if (custumer.address.us == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string packingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"{product.name} (ID: {product.productId})\n";
        }
        return label;
    }

    public string shippingLabel()
    {
        Console.WriteLine(custumer.name);
        custumer.address.labelAddress();

        return "";
    }

}