using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program.");

        string choice = "";

        while (choice != "5")
        {
            DisplayMenu();  
            Console.Write("What do you want to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // write entry
                Console.Write("Writing a new entry.");
            }
            else if (choice == "2")
            {
                // Load entries from file
                
                theJournal.Display();
                
            }
            else if (choice == "3")
            {
                // Save entry to file
                Console.Write("Saving the new entry.");
               
               
            }
            else if (choice == "4")
            {
                // Display entry from file
                Console.Write("Displaying the new entry.");
            }
            else if (choice == "5")
            {
                // Quit program
                Console.Write("Ending the program, goodbye.");
            }

        }

    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Load");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Display");
        Console.WriteLine("5. End");
    }
}