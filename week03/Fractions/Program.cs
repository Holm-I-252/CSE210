using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction_1 = new Fraction();
        Fraction fraction_2 = new Fraction(3);
        Fraction fraction_3 = new Fraction(1, 2);

        fraction_1.SetTop(5);
        fraction_1.SetBottom(10);

        Console.WriteLine($"Fraction 1: {fraction_1.GetFractionString()}");
        Console.WriteLine($"Deciaml 1: {fraction_1.GetDecimalValue()}");
    }
}