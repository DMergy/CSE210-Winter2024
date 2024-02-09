using System;

class Program

{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f5 = new Fraction(5);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Fraction f34 = new Fraction(3, 4);
        Console.WriteLine(f34.GetFractionString());
        Console.WriteLine(f34.GetDecimalValue());

        Fraction f13 = new Fraction(1, 3);
        Console.WriteLine(f13.GetFractionString());
        Console.WriteLine(f13.GetDecimalValue());
    }
}