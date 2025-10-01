using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        //Using the pre defined and display in the other file, I can us these to output 1/1, 5/1, and 5/5.
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5, 5);

        //This both gets and sets the numerator, then the denominator
        fraction1.SetTop(fraction1.GetTop());
        fraction1.SetBot(fraction1.GetBot());
    }
}