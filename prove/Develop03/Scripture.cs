public class Scripture
{
    public List<Reference> _scripture = new List<Reference>();

    public void DisplayScripture()
    {
        _scripture[0].Display();
    }
}