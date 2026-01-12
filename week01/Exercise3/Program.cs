using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        String input1 = Console.ReadLine();
        int magicNumber = int.Parse(input1);

        int guess;

        do{
            Console.Write("What is your guess?");
            String input2 = Console.ReadLine();
            guess = int.Parse(input2);

            if(magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if(guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Sorry, that is incorrect.");
            }
        }while(magicNumber != guess);
        
    }
}