using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();
        
        while (true)
        {
            Console.Write("Enter a number: ");
            String input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                int sumNumbers = 0;
                float numbersAvg = 0;
                numbers.Add(number);
                for (int i = 0; i < numbers.Count; i++)
                {
                    sumNumbers += numbers[i];
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    numbersAvg = sumNumbers / (numbers.Count - 1);
                }
                Console.WriteLine($"The sum of the numbers is: {sumNumbers}");
                Console.WriteLine($"The average number is: {numbersAvg}");
                Console.WriteLine($"The max number is: {numbers.Max()}");
                break;
            }

            numbers.Add(number);
        }
    }
}