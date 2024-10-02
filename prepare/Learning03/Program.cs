using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetDecimalValue());


        Fraction fraction2 = new Fraction(6);
        fraction2.SetBottom(3);
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());



        Fraction fraction3 = new Fraction(6,7);
        fraction3.SetTop(5);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetDecimalValue());

        
    }
}