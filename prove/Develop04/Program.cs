using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Activities a1 = new Activities("Hello There", "Goodbye There");
        Console.WriteLine("");
        Console.WriteLine("How much time would you like to wait?");
        a1.SetTime(int.Parse(Console.ReadLine()));
        a1.GetAnimation();
    }
}