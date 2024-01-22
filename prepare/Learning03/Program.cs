using System;
using System.Formats.Asn1;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the numerator? ");
        string answerTop = Console.ReadLine();
        int top = int.Parse(answerTop);

        Console.Write("What is the numerator? ");
        string answerBottom = Console.ReadLine();
        int bottom = int.Parse(answerBottom);

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString()); 
        Console.WriteLine(fraction.GeDecimalValue());

        Fraction fraction1 = new Fraction(top);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GeDecimalValue());

        Fraction fraction2 = new Fraction(top, bottom);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GeDecimalValue());
    }
}