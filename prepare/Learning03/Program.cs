using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        //Using the pre defined and display in the other file, I can us these to output 1/1, 5/1, and 5/5.
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5, 1);

        //This both gets and sets the numerator, then the denominator
        fraction1.SetTop(fraction1.GetTop());
        fraction1.SetBot(fraction1.GetBot());

        //These will use the previous function user input as thier inputs, providing the fraction for and the decimal form.
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(""); //Just a space to seperate

        //This is the final tesing using pre given numbers
        Fraction fraction5 = new Fraction();
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        //All of the other ones work, exept for this one. Any ideas as to why?
        Fraction fraction6 = new Fraction(5);
        Console.WriteLine(fraction6.GetFractionString());
        Console.WriteLine(fraction6.GetDecimalValue());

        //These also work
        Fraction fraction7 = new Fraction(3, 4);
        Console.WriteLine(fraction7.GetFractionString());
        Console.WriteLine(fraction7.GetDecimalValue());
        Fraction fraction8 = new Fraction(1, 3);
        Console.WriteLine(fraction8.GetFractionString());
        Console.WriteLine(fraction8.GetDecimalValue());
    }
}