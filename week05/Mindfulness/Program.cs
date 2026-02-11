using System;

class Program
{
    static void Main(string[] args)
    { 

        BreathingActivity breathing = new Breathing();
        Console.WriteLine("Be Welcome to the wellness program!");

        while(true)
        {
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breating Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Refleting Activity");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("**Type a Valid Number**");
            }
        }

        
    }
}