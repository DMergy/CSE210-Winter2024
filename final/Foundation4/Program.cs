using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();

        Running running = new Running("April 26, 2024", 30, 4.8);
        exerciseList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("April 27, 2024", 60, 15);
        exerciseList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("April 28, 2024", 20, 20);
        exerciseList.Add(swimming);

        Console.WriteLine("Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}