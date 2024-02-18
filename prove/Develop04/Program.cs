using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Menu Options:");

        string choice = "";

        while (choice != "4")
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // breathing activity
                Console.Write("Welcome to the Breathing Activity.");
            }
            else if (choice == "2")
            {
                // reflecting activity
                Console.Write("Welcome to the Reflecting Activity.");

            }
            else if (choice == "3")
            {
                // listing activity
                Console.Write("Welcome to the Listing Activity.");


            }

            else if (choice == "4")
            {
                // Quit program
                Console.Write("Ending the program, goodbye.");
            }

        }

    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        
    }
}