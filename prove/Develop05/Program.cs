using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Drawing;

class Program
{
    //To Go above and beyond, I added a Text and Background color, and Secret Goal in a shop that you can exchange points for. 
    // Your purchases are also saved and loaded, and colors can be changed in the shop
    static void Main(string[] args)
    {
        int totalPoints = 0;
        //totalPoints = classInstanceName.AddPoints(totalPoints);
        List<EternalGoal> EternalGoalList = new List<EternalGoal>();
        List<ChecklistGoal> ChecklistGoalList = new List<ChecklistGoal>();
        List<SimpleGoal> SimpleGoalList = new List<SimpleGoal>();

        //Makes the shop available
        Shop shop = new Shop();
        string userInput = "0";
        do
        {
            Console.WriteLine("");
            Console.WriteLine($"Total Points: {totalPoints}");
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
                    SimpleGoalList.Add(simpleGoal);
                }
                else if (userInput == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetEternalGoal();
                    EternalGoalList.Add(eternalGoal);
                }
                else if (userInput == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.SetChecklistGoal();
                    ChecklistGoalList.Add(checklistGoal);
                }
                else { Console.WriteLine("Error, invalid input."); }
                //Each is added to the list to keep track of later
            }

            else if (userInput == "2")
            {
                foreach (var goal in SimpleGoalList)
                {
                    Console.WriteLine("");
                    goal.DisplayGoal(1);
                }
                foreach (var goal in EternalGoalList)
                {
                    Console.WriteLine("");
                    goal.DisplayGoal(1);
                }
                foreach (var goal in ChecklistGoalList)
                {
                    Console.WriteLine("");
                    goal.DisplayGoal(1);
                }
            }

            //Saving Option
            else if (userInput == "3")
            {
                string filename = "saveFile.txt";

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"#,{totalPoints}");
                    foreach (var goal in SimpleGoalList)
                    {
                        outputFile.WriteLine($"$,{goal.DisplayGoal(0)}");
                    }
                    foreach (var goal in EternalGoalList)
                    {
                        outputFile.WriteLine($"%,{goal.DisplayGoal(0)}");
                    }
                    foreach (var goal in ChecklistGoalList)
                    {
                        outputFile.WriteLine($"&,{goal.DisplayGoal(0)}");
                    }
                    outputFile.Write("1,");
                    foreach (var color in shop._textColors)
                    {
                        outputFile.Write($"{color},");
                    }
                    outputFile.WriteLine();
                    outputFile.Write("2,");
                    foreach (var color in shop._ownedTextColors)
                    {
                        outputFile.Write($"{color},");
                    }
                    outputFile.WriteLine();
                    outputFile.Write("3,");
                    foreach (var color in shop._backgroundColors)
                    {
                        outputFile.Write($"{color},");
                    }
                    outputFile.WriteLine();
                    outputFile.Write("4,");
                    foreach (var color in shop._ownedBackgroundColors)
                    {
                        outputFile.Write($"{color},");
                    }
                }
            }

            //Loading Option
            else if (userInput == "4")
            {
                string filename = "saveFile.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    if (parts[0] == "$")
                    {
                        SimpleGoalList.Clear();
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1], int.Parse(parts[4]), parts[2], parts[3]);
                        SimpleGoalList.Add(simpleGoal);
                    }
                    if (parts[0] == "%")
                    {
                        EternalGoalList.Clear();
                        EternalGoal eternalGoal = new EternalGoal(int.Parse(parts[3]), parts[1], parts[2]);
                        EternalGoalList.Add(eternalGoal);
                    }
                    if (parts[0] == "&")
                    {
                        ChecklistGoalList.Clear();
                        ChecklistGoal checklistGoal = new ChecklistGoal(int.Parse(parts[4]), int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]), parts[1], parts[2]);
                        ChecklistGoalList.Add(checklistGoal);
                    }
                    if (parts[0] == "#") { totalPoints = int.Parse(parts[1]); }
                    if (parts[0] == "1")
                    {
                        shop._textColors.Clear();
                        int skip = 1;
                        foreach (var color in parts)
                        {
                            if (skip == 1) { skip -= 1; }
                            else{shop._textColors.Add(color);}
                        }
                    }
                    if (parts[0] == "2")
                    {
                        shop._ownedTextColors.Clear();
                        int skip = 1;
                        foreach (var color in parts)
                        {
                            if (skip == 1) { skip -= 1; }
                            else{shop._ownedTextColors.Add(color);}
                        }
                    }
                    if (parts[0] == "3")
                    {
                        shop._backgroundColors.Clear();
                        int skip = 1;
                        foreach (var color in parts)
                        {
                            if (skip == 1) { skip -= 1; }
                            else{shop._backgroundColors.Add(color);}
                        }
                    }
                    if (parts[0] == "4")
                    {
                        shop._ownedBackgroundColors.Clear();
                        int skip = 1;
                        foreach (var color in parts)
                        {
                            if (skip == 1) { skip -= 1; }
                            else{shop._ownedBackgroundColors.Add(color);}
                        }
                    }
                }
            }

            //Goal Achievment
            else if (userInput == "5")
            {
                Console.WriteLine("");
                int i = 1;
                foreach (var goal in SimpleGoalList)
                {
                    Console.Write($"{i}. ");
                    i += 1;
                    goal.DisplayGoal(1);
                }
                foreach (var goal in EternalGoalList)
                {
                    Console.Write($"{i}. ");
                    i += 1;
                    goal.DisplayGoal(1);
                }
                foreach (var goal in ChecklistGoalList)
                {
                    Console.Write($"{i}. ");
                    i += 1;
                    goal.DisplayGoal(1);
                }
                Console.Write("Which goal have you accomplished? ");
                int userIntInput = EternalGoalList[0].CheckInt();
                Console.WriteLine(userIntInput);
                //Simple Goal completion
                if (userIntInput > SimpleGoalList.Count())
                {
                    userIntInput -= SimpleGoalList.Count();
                    Console.WriteLine(userIntInput);
                    //Eternal Goal completion
                    if (userIntInput > EternalGoalList.Count())
                    {
                        userIntInput -= EternalGoalList.Count();
                        Console.WriteLine(userIntInput);
                        //Checklist Goal completion
                        if (userIntInput > ChecklistGoalList.Count())
                        {
                            Console.WriteLine("Error");
                        }
                        else
                        {
                            userIntInput -= 1;
                            totalPoints = ChecklistGoalList[userIntInput].AddPoints(totalPoints);
                            Console.WriteLine("Sucess 3");
                        }
                    }
                    else if (userIntInput <= EternalGoalList.Count())
                    {
                        userIntInput -= 1;
                        totalPoints = EternalGoalList[userIntInput].AddPoints(totalPoints);
                        Console.WriteLine("Sucess 2");
                    }
                }
                else if (userIntInput <= SimpleGoalList.Count())
                {
                    userIntInput -= 1;
                    if (SimpleGoalList[userIntInput].GetXMark() == " ") { totalPoints = SimpleGoalList[userIntInput].AddPoints(totalPoints); }
                    SimpleGoalList[userIntInput].SetCompleted();
                    Console.WriteLine("Sucess");
                }
            }

            //The shop for fun
            else if (userInput == "6")
            {
                Console.WriteLine("");
                Console.WriteLine("This is the Shop! the items you can buy are: ");
                Console.WriteLine(" 1. Text Colors");
                Console.WriteLine(" 2. Background Colors");
                Console.WriteLine(" 3. Secret Goals!");
                Console.WriteLine(" 4. Set Colors");
                Console.WriteLine("Please select your desire (if you have enough point)! ");
                userInput = Console.ReadLine();
                if (userInput == "1") { totalPoints = shop.BuyTextColors(totalPoints); }
                if (userInput == "2") { totalPoints = shop.BuyBackgroundColors(totalPoints); }
                if (userInput == "3")
                {
                    if (totalPoints > 500)
                    {
                        EternalGoal eternalGoal = new EternalGoal(20, "Free Bee", "This Goal gives you 20 points each time you accomplish it, for free!");
                        EternalGoalList.Add(eternalGoal);
                    }
                }
                if (userInput == "4") { shop.SetColors(); }
                if (userInput == "5") { Console.WriteLine("Error in choice"); }
            }

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

