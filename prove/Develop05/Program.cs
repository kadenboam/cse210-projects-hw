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

            if (userInput == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("Goal types: ");
                Console.WriteLine(" 1. One and Done Goal");
                Console.WriteLine(" 2. Forever Goal");
                Console.WriteLine(" 2. Repeating Goal");
                Console.Write("What kind of goal would you like to set? ");
                userInput = Console.ReadLine();

                //Different sections for setting the new goal
                if (userInput == "1")
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetSimpleGoal();
                    GoalList.Add(simpleGoal);
                }
                else if (userInput == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetEternalGoal();
                    GoalList.Add(eternalGoal);
                }
                else if (userInput == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetChecklistGoal();
                    GoalList.Add(checklistGoal);
                }
                else { Console.WriteLine("Error, invalid input."); }
                //Each is added to the list to keep track of later
            }

            else if (userInput == "2")
            {
                foreach (var goal in GoalList)
                {
                    goal.DisplayGoal();
                }
            }

            else if (userInput == "3") { }

            else if (userInput == "4") { }

            else if (userInput == "5") { }

            else if (userInput == "6") { }

            else if (userInput == "7") { Console.WriteLine("Exiting the program..."); }
            else { Console.WriteLine("Error, invalid input."); }
        } while (userInput != "7");
    }

    //The menu options
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

