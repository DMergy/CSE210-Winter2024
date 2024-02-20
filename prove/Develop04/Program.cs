using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("*** Welcome to the Mindfulness Program ***");

        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    Console.Clear();
                    Breathing breathing = new Breathing("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    breathing.GetReady();
                    breathing.BreathingActivity(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    Console.Clear();
                    Reflecting reflecting = new Reflecting("Reflecting", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetActivityTime();
                    reflecting.GetReady();
                    reflecting.DisplayPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    Console.Clear();
                    Listing listing = new Listing("Listing", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetActivityTime();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine($"Sorry the option you entered is not valid.");
                    break;
            }

        }

    }

}