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
        //or
        //Console.WriteLine(GetFractionString());
    }
    public Fraction(int wholeNumber)
    {
        _denominator = 1;
        Console.WriteLine($"{wholeNumber}/{_denominator}");
        //or
        //Console.WriteLine(GetFractionString());
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        Console.WriteLine($"{numerator}/{denominator}");
        //or
        //Console.WriteLine(GetFractionString());
    }

    //Funnctions used to get the values, as well as set the values and display them.
    public int GetTop()
    {
        Console.Write("What is the Numerator? ");
        _numerator = int.Parse(Console.ReadLine());
        return _numerator;
    }
    public void SetTop(int numerator)
    {
        _numerator = numerator;
        Console.WriteLine($"{_numerator}/{_denominator}");
    }
    public int GetBot()
    {
        Console.Write("What is the Denominator? ");
        _denominator = int.Parse(Console.ReadLine());
        return _denominator;
    }
    public void SetBot(int denominator)
    {
        _denominator = denominator;
        Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public string GetFractionString()
    {
        string fraction = $"{_numerator}/{_denominator}";
        return fraction;
    }

    public double GetDecimalValue() {
        double decimals = (double)_numerator / (double)_denominator;
        return decimals;
    }
}