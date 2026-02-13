using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Be Welcome to the wellness program!");

        while(true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Refleting Activity");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", desc);
                breathing.Run();
            }
            else if (choice == "2")
            {
                string desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
                ListingActivity listing = new ListingActivity("Listing Activity", desc);
                listing.Run();
            }
            else if (choice == "3")
            {
                string desc = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", desc);
                reflecting.Run();
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