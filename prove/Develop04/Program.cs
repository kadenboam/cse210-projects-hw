using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("");
        Activities a1 = new Activities("This Mindfullness activity will help you take time out of your day to relax and think. How much time (in seconds) would you like it to be? ", "You did great today. Comeback if you would like to do another session with us, but untill then, namaste.");
        a1.StartMessage();
        a1.SetTime(int.Parse(Console.ReadLine()));
        a1.GetAnimation();
        Console.WriteLine("");
        a1.EndMessage();
    }
}