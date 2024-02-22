using System;

public class Program
{

    static void Main()
    {
        Scripture scripture = new Scripture("John", 15, 13, "Greater love hath no man than this, that a man lay down his life for his friends.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nYou got this, you memorized the scripture!!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }
    }
}