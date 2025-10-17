using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        //totalPoints = classInstanceName.AddPoints(totalPoints);
        List<Goal> GoalList = new List<Goal>();
        string userInput = "0";
        do
        {
            DisplayMenu();
            userInput = Console.ReadLine();
        } while (userInput != "7");
    }
    static void DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Menu: ");
        Console.WriteLine(" 1. Set A Goal");
        Console.WriteLine(" 2. List Current Goals");
        Console.WriteLine(" 3. Save Your Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Goal Achieved");
        Console.WriteLine(" 6. Shop");
        Console.WriteLine(" 7. Quit");
        Console.Write("What would you like to do? ");
    }
}

