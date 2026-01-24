using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);


        Console.WriteLine($"Fraction num1: {frac1}");
        Console.WriteLine($"Fraction num2: {frac2}");
        Console.WriteLine($"Fraction num3: {frac3}");
        Console.WriteLine($"Decimal value of num1: {frac1.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of num2: {frac2.GetDecimalValue()}");
        Console.WriteLine($"Decimal value of num3: {frac3.GetDecimalValue()}");

    }
}