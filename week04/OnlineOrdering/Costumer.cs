public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        // Encapsulamento: o cliente pergunta ao endereço se é nos EUA
        return _address.IsInUSA();
    }

    public string GetName() => _name;
    public string GetAddressDetails() => _address.GetFullAddress();
}