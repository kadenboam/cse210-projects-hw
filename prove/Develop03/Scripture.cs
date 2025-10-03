public class Scripture
{
    //Makes a list so we can store multiple scriptures
    public List<Reference> _scripture = new List<Reference>();


    //For now, all this does is display a scripture. Later a input could be added to randomize the chosen scripture
    public void DisplayScripture()
    {
        _scripture[0].Display();
    }
}