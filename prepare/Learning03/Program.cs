using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        Console.WriteLine($"{fraction1.GetTop()}");
        Console.WriteLine($"{fraction2.GetTop()}");
        Console.WriteLine($"{fraction3.GetBottom()}");

        //fraction1.SetTop(10);
        fraction1.SetBottom(3);
        Console.WriteLine($"{fraction1.GetTop()}");

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine($"{fraction1.GetDecimalValue()}");








    }
}