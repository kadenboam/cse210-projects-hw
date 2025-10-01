public class Fraction
{
    private int _numerator;
    private int _denominator;

    //These pre-define the above with displaying them
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
        Console.WriteLine($"{_numerator}/{_denominator}");
    }
    public Fraction(int wholeNumber)
    {
        _denominator = 1;
        Console.WriteLine($"{wholeNumber}/{_denominator}");
    }
    public Fraction(int numerator, int denominator)
    {
        Console.WriteLine($"{numerator}/{denominator}");
    }

}