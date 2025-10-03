public class Reference
{
    private string _book;
    private int _chapter;
    private string _numberOfVerse;
    private string _verse;

    public Reference(string Book, int Chapter, string NumberOfVerse, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _numberOfVerse = NumberOfVerse;
        _verse = Verse;
    }
    public Reference(string Book, int Chapter, int NumberOfVerse, int EndVerse, string Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _numberOfVerse = $"{NumberOfVerse}-{EndVerse}";
        _verse = Verse;
    }
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_numberOfVerse}");
        Console.WriteLine($"{_verse}");
    }
}