using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("This is a colorful message!");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Styled text with background color!");
        Console.ResetColor();
    }
}