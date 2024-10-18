using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction num1 = new Fraction();
        Fraction num2 = new Fraction(5);
        Fraction num3 = new Fraction(3,4);
        Fraction num4 = new Fraction(1,3);

        Console.WriteLine(num1.GetFractionString());
        Console.WriteLine(num1.GetDecimalValue());
        Console.WriteLine(num2.GetFractionString());
        Console.WriteLine(num2.GetDecimalValue());
        Console.WriteLine(num3.GetFractionString());
        Console.WriteLine(num3.GetDecimalValue());
        Console.WriteLine(num4.GetFractionString());
        Console.WriteLine(num4.GetDecimalValue());

    }
}