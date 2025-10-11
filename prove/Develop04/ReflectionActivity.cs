public class ReflectionActivity : Activities
{
    //Initializing the class variables
    private string _reflectionMessage;

    //Arrays seem to be the best option for these to lists
    private string[] _prompt =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you felt the most happy today.",
        "Think of a time when you were the most peacfull"
    };
    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "How can you keep this experience in mind in the future?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?"
    };

    public ReflectionActivity(string startMessage, string endMessage, string reflectionMessage) : base(startMessage, endMessage)
    {
        _reflectionMessage = reflectionMessage;
    }

    public void ReflectionDescription()
    {
        Console.WriteLine(_reflectionMessage);
        Console.WriteLine("");
        Console.WriteLine("How much time (in seconds) would you like it to be?");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine(_prompt[RandomePrompter()]);
        Console.WriteLine("");
        Console.WriteLine("When you are ready, press enter");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder the following questions as you think about this experience");
        int loop = 0;
        SetDateTime(time);
        do
        {
            GetAnimation("$");
            Console.Clear();
            Console.Write(_questions[loop]);
            loop += 1;
            if (loop > _questions.Count()) { loop = 0; }
        } while (currentTime < futureTime);
    }
    public int RandomePrompter()
    {
        Random random = new Random();
        int randomPrompt = random.Next(0, _prompt.Count());
        return randomPrompt;
    }
}