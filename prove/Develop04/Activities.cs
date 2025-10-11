public class Activities
{
    //Initializing the values
    private int _time;
    private string[] _animation = { "|", "/", "-", "\\" };
    private int _loop = 0;
    protected string _startMessage;
    protected string _endMessage;

    DateTime startTime;
    DateTime futureTime;
    
    //Constructor for initializing variables
    public Activities(string startMessage, string endMessage)
    {
        _startMessage = startMessage;
        _endMessage = endMessage;
    }

    //Void functions for doing things that are entirley in the Activities (this) class
    public void SetTime(int time)
    {
        _time = time;
    }
    public void GetAnimation()
    {
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(_time);
        DateTime currentTime = startTime;
        do
        {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(_animation[_loop]);
            _loop += 1;
            if (_loop > 3) { _loop = 0; }
            currentTime = DateTime.Now;
        } while (currentTime < futureTime);
    }

    public void StartMessage()
    {
        Console.WriteLine(_startMessage);
    }
    public void EndMessage()
    {
        Console.WriteLine(_endMessage);
    }
}