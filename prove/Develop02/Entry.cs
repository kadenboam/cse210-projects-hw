public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    public string _mood = "";
    public int _rating = 0;
    public string _title = "";
    public string _miracles = "";
    public string _miracleTitles = "";
    public void DisplayEntry()
    {
        if (_title != "") { Console.WriteLine($"Title: {_title}"); }
        if (_rating != 0) { Console.WriteLine($"Rating: {_rating}"); }

        //This code was improperly written causing problems in the experimental part of program.cs
        //{_mood} was added where it was supposed to go
        if (_mood != "") { Console.WriteLine($"Mood: {_mood}"); }
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        if (_miracleTitles != "") { Console.WriteLine($"The {_miracleTitles} Miracle!"); }
        if (_miracles != "") { Console.WriteLine($"Miracle: {_miracles}"); }
    }
    // In testing, however the display all function works fine
    public void DisplayEachMiracle()
    {
        if (_miracleTitles != "") { Console.WriteLine($"The {_miracleTitles} Miracle!"); }
        if (_miracles != "") { Console.WriteLine($"Miracle: {_miracles}"); }
    }
}