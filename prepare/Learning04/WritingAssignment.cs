public class WritingAssignment : Assignment
{
    private string _title;

    //This gets title with no need to declare the others here since they do it in the assignment class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritinginformation()
    {
        return $"{_title}";
    }
}