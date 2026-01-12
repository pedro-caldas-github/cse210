using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        
        return number;
    } 

    static int SquareNumber (int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void DisplayResult(string name, int number)
    {
        int squaredNumber = number * number;
        Console.WriteLine($"{name}, the square of your favorite number {number} is {squaredNumber}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        SquareNumber(userNumber);
        DisplayResult(userName, userNumber);
    }
}