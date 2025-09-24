// A class for Job, to hold the rest of the information that will be recieved.
public class Job
{
    // different values that will be stored
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    //simple named function that describes the Job
    public void TheJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}