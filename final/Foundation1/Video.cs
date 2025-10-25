class Video {
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> comment = new List<Comment>();

    //Simplifying video initialization
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    
    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} By:{_author} Duration:{_length} Comments:{comment.Count()}");
        foreach (var person in comment)
        {
            Console.Write("     ");
            person.DisplayComment();
        }
        Console.WriteLine("");
    }
}