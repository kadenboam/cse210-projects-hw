public class BreathingActivity : Activities
{
    //Initialization
    private string _breathingMessage;

    public BreathingActivity(string startMessage, string endMessage, string breathingMessage) : base(startMessage, endMessage)
    {
        _breathingMessage = breathingMessage;
    }
    
    //Function originally for showing breathing description, complete breathing activity added to keep program.cs clear and clean
    public void BreathingDescription(int time)
    {
        Console.WriteLine(_breathingMessage);
        Console.WriteLine("");

        //after the message, the time is set in case time has passed since the initial setting
        SetDateTime(time);

        //A simple loop of breathing in and out until the time is up
        do
        {
            Console.Clear();
            Console.WriteLine("Breath In...");
            GetAnimation();
            Console.Clear();
            Console.WriteLine("Breath Out...");
            GetAnimation();
        } while (currentTime < futureTime);
    }
}