using System;

class Program
{
    static void TheBirthYear(out int userBirthYear)
    {
        Console.Write("Please enter the year you were born: ");
        userBirthYear = int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        ShowWelcome();
        string name = TheName();
        Console.Write("Please enter your favorite number: ");
        int number = TheNumber();
        int userBirthYear;
        TheBirthYear(out userBirthYear);
        int squaredNumber = ChangeNumber(number);
        NameAndNumber(name, squaredNumber, userBirthYear);
    }

    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string TheName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int TheNumber()
    {
        int userFavNumber = int.Parse(Console.ReadLine());
        return userFavNumber;
    }
    static int ChangeNumber(int x)
    {
        x = x * x;
        return x;
    }
    static void NameAndNumber(string x, int y, int z) {
        int age = 2025 - z;
        Console.WriteLine($"{x}, the square of your number is {y}.");
        Console.WriteLine($"{x}, you will turn {age} this year.");
    }
}