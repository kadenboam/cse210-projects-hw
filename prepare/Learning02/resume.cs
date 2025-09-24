public class Resume
{
    //Name value for the class
    public string _name = "";
    //List value for the class, Make sure to set correctly!
    public List<Job> _jobs = new List<Job>();

    //Function to display the above values
    public void ResumeDisplay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //Function that will loop till all jobs (Job class) in _jobs is displayed
        foreach (Job k in _jobs)
        {
            //Original test for list display
            k.TheJob();

            /* Other Display Format
            Console.WriteLine($"Company: {k._company}");
            Console.WriteLine($"Job Title: {k._jobTitle}");
            Console.WriteLine($"Dates: {k._startYear}-{k._endYear}");
            Console.WriteLine("");
            */
        }
    }
}