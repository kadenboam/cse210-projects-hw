public class ListingActivity : Activities
{
    private string _listingMessage;
    private string[] _listPrompt =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Who are people that you have helped this week?"
    };
    private List<string> _userList = new List<string>();

    public ListingActivity(string startMessage, string endMessage, string listingMessage) : base(startMessage, endMessage)
    {
        _listingMessage = listingMessage;
    }

    public void ListingDescription()
    {
        Console.WriteLine(_listingMessage);
        Console.WriteLine("");
        Console.WriteLine("How much time (in seconds) would you like it to be?");
        int time = int.Parse(Console.ReadLine());
        GetAnimation("$");
        Console.WriteLine("");
        Console.WriteLine("List as many things as you can about the following Prompt: ");
        Random random = new Random();
        int randomPrompt = random.Next(0, _listPrompt.Count());
        Console.WriteLine(_listPrompt[randomPrompt]);
        Console.WriteLine("Begin in:");
        GetAnimation("#");

        SetDateTime(time);
        do
        {
            Console.Write(">");
            SetUserList(Console.ReadLine());
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
        Console.WriteLine("");
        Console.WriteLine($"You have listed {_userList.Count} items!");
        GetAnimation("$");
        Console.Clear();
    }
    public void SetUserList(string input)
    {
        _userList.Add(input);
    }
    public void GetUserList()
    {
        for (int i = 0; i <= _userList.Count; i++)
        {
            Console.WriteLine(_userList[i]);
        }
    }
}