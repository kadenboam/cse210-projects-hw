public class Reference
{
    //Adding the variables for a scripture
    private string _book;
    private int _chapter;
    private string _numberOfVerse;
    private string _verse;


    //Two simple set ups depending on if it is a singular vers or multiple verses
    public Reference(string Book, int Chapter, string NumberOfVerse, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _numberOfVerse = NumberOfVerse;
        _verse = Verse;
    }
    //Redundancy in case there is confusion on putting "1" or 1
    public Reference(string Book, int Chapter, int NumberOfVerse, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _numberOfVerse = $"{NumberOfVerse}";
        _verse = Verse;
    }
    public Reference(string Book, int Chapter, int StartVerse, int EndVerse, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _numberOfVerse = $"{StartVerse}-{EndVerse}";
        _verse = Verse;
    }

    //Function to Display the scripture, allowing the showing of the private variables.
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_numberOfVerse}");
        
    }

    public string GetVerse()
    {
        return _verse;
    }
}