class Comment {
    public string _userName;
    public string _commentText;

    //To simplify defining comments
    public Comment(string userName, string commentText)
    {
        _userName = userName;
        _commentText = commentText;
    }
    
    //For displaying each comment 
    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}:");
        Console.WriteLine($"{_commentText}");
    }
}