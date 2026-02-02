using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Address
{
    public string street;
    public string city;
    public string state;
    public string country;
    public bool us;

    public void isUSAddress()
    {
        
        if (country == "USA" || country == "usa" || country == "United States" || country == "United States of America")
        {
            us = true;
        }
        else
        {
            us = false;
        }
    }

    public void labelAddress()
    {
        Console.WriteLine(street);
        Console.WriteLine($"{city}, {state}");
        Console.WriteLine(country);
    }
}