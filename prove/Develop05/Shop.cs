public class Shop
{
    //This is for extra, fill in after completing the assignment.
    //Text Colors
    public List<string> _textColors = new List<string>();
    public List<string> _ownedTextColors = new List<string>();

    //Backround colors
    public List<string> _backgroundColors = new List<string>();
    public List<string> _ownedBackgroundColors = new List<string>();

    public Shop()
    {
        _ownedTextColors.Add("Gray");
        _ownedBackgroundColors.Add("White");
    }

    public int BuyTextColors(int totalPoints)
    {
        Console.WriteLine("Text Colors cost 1000 points each: ");
        foreach (string i in _textColors) { Console.Write($"{i}, "); }
        Console.WriteLine("");
        Console.Write("What would you like to get? ");
        string userInput = Console.ReadLine();
        bool check = _textColors.Contains(userInput);
        if (check == false)
        {
            Console.WriteLine("It was incorrectly stated or error, try again.");
        }
        else if (totalPoints > 1000)
        {
            _ownedTextColors.Add(userInput);
            _textColors.Remove(userInput);
            totalPoints -= 1000;
            Console.WriteLine("Purchase sucessful! ");
        }
        return totalPoints;
    }
    public int BuyBackgroundColors(int totalPoints)
    {
        Console.WriteLine("Background Colors cost 1000 points each: ");
        foreach (string i in _backgroundColors) { Console.Write($"{i}, "); }
        Console.WriteLine("");
        Console.Write("What would you like to get? ");
        string userInput = Console.ReadLine();
        bool check = _backgroundColors.Contains(userInput);
        if (check == false)
        {
            Console.WriteLine("It was incorrectly stated or error, try again.");
        }
        else if (totalPoints > 1000)
        {
            _ownedBackgroundColors.Add(userInput);
            _backgroundColors.Remove(userInput);
            totalPoints -= 1000;
            Console.WriteLine("Purchase sucessful! ");
        }
        return totalPoints;
    }
    public void SetColors()
    {
        //This was thanks to some online searching: https://learn.microsoft.com/en-us/dotnet/api/system.consolecolor?view=net-9.0
        foreach (string i in _ownedBackgroundColors) { Console.Write($"{i}, "); }
        Console.Write("What Color do you want the background to be? ");
        string userInput = Console.ReadLine();
        if (_ownedBackgroundColors.Contains(userInput))
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), userInput);
        }
        Console.WriteLine("");
        foreach (string i in _ownedTextColors) { Console.Write($"{i}, "); }
        Console.Write("What Color do you want the text to be? ");
        userInput = Console.ReadLine();
        if (_ownedTextColors.Contains(userInput))
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), userInput);
        }
    }
}