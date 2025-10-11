using System.Security.Cryptography.X509Certificates;

public class Activities
{
    //Initializing the values
    protected int _time;
    private string[] _animation = { "|", "/", "-", "\\" };
    private int _loop = 0;
    protected string _startMessage;
    protected string _endMessage;

    public DateTime startTime;
    public DateTime futureTime;

    public DateTime currentTime;
    
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

    //This function was found to be needed for the breathing activity and so it was implemented
    public int GetTime()
    {
        return _time;
    }

    //Seperate Setting time from GetAnimation was needed, so now they can initialize and run seperatly
    public void SetDateTime(int time)
    {
        startTime = DateTime.Now;
        futureTime = startTime.AddSeconds(time);
        currentTime = startTime;
    }

    //Animation function for a simple loop pattern
    public void GetAnimation(string animationType)
    {
        //Symbol animation
        if (animationType == "$")
        {
            string[] _animation = { "|", "/", "-", "\\" };
            DateTime pastTime = DateTime.Now;
            do
            {
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write(_animation[_loop]);
                _loop += 1;
                if (_loop > 3) { _loop = 0; }
                currentTime = DateTime.Now;
                //This only runs on 5 seconds now, but can be modified if needed
            } while (currentTime < pastTime.AddSeconds(5));
        }

        //Countdown Animation
        else if (animationType == "#")
        {
            string[] _animation = { "5", "4", "3", "2", "1"};
            int i = 0;
            while (i < 5)
            {

                Console.Write("\b \b");
                Console.Write(_animation[_loop]);
                _loop += 1;
                if (_loop > 4) { _loop = 0; }
                currentTime = DateTime.Now;
                Thread.Sleep(1000);
                //This only runs on 5 seconds now, but can be modified if needed
                i += 1;
            }
        }
    }

    public string StartMessage()
    {
        return _startMessage;
    }
    public string EndMessage()
    {
        return _endMessage;
    }
}