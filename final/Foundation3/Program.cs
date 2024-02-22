using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Harvard University", "Cambridge", "Massachusetts", "USA");

        Lecture lecture = new Lecture("Public Observatory Night at the Harvard College Observatory | Jupiter", "Embark on an evening with two captivating talks centered around Jupiter", "February 26, 2024", "6:30 PM", address, "TBD", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Mr. and Mrs. James Smith", "La Jolla", "California", "USA");

        Reception reception = new Reception("Wedding Reception", "Join James and Julia in celebrating their joining together for eternity.", "April 26, 2024", "4 PM", addressR, "reception.jsmith@ldslajollaward.com");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Del Mar Fair", "Del Mar", "California", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Annual San Diego County Fair", "Let's Go Retro 2024 - Opening Day", "June 12, 2024", "9 AM", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
    
}