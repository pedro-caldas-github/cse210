using System;

class Program
{
    static void Main(string[] args)
    {
        Activity a = new Activity("Teste", "Teste", 5); 
        BreathingActivity b = new BreathingActivity("Breathing", "A simple breathing exercise to help you relax.", 5);
        a.ShowSpinner(5);
        a.ShowCountdown(5);
        b.Run();
        
    }
}