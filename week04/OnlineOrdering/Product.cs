public class Product
{
    
    public string name;
    public string productId;
    public double price;
    public int quantity;

    public double totalPrice()
    {
        return price * quantity;
    }

    public void addProduct(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

}