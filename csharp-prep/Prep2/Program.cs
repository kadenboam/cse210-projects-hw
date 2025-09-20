using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);
        string letter = "";
        string sign = "";
        if (gradePercentage >= 90) { letter = "A!"; }
        else if (gradePercentage >= 80) { letter = "B!"; }
        else if (gradePercentage >= 70) { letter = "C!"; }
        else if (gradePercentage >= 60) { letter = "D."; }
        else if (gradePercentage <= 60) { letter = "F."; }
        else { Console.WriteLine("An Error has Occured!"); letter = "error"; }
        int remainder = gradePercentage % 10;
        if (remainder >= 7 || gradePercentage >= 100) { sign = "+"; }
        else if (remainder <= 3 || gradePercentage <=53) { sign = "-"; }
        Console.WriteLine($"You have an {sign}{letter}");
        if (gradePercentage >= 70) { Console.WriteLine("You have passed!"); }
        else if (gradePercentage <= 70) { Console.WriteLine("You failed. Lets try again!"); }

    }
}