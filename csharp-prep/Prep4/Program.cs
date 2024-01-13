using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int givenNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (givenNumber != 0)
        {
            Console.Write("Enter number: ");

            string givenResponse = Console.ReadLine();
            givenNumber = int.Parse(givenResponse);

            if (givenNumber != 0)
            {
                numbers.Add(givenNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }

        Console.WriteLine($"The max is: {maximum}");
    }
}