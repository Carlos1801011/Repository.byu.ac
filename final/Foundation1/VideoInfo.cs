public class Video
{
    private string _author;
    private string _title;
    private int _lenght;
    private List<Comment> _comments;


    // Settings for the text header
    public Video(string author, string title, int lenght)
    {
        _author = author;
        _title = title;
        _lenght = lenght;
        _comments = new List<Comment>();
    }

    //setting for the comments
    public void AddCommentNew(string author, string comment)
    {
        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }
  
    //setting for the header with the text incluided
    public void DisplayVideoInfo()
    {
        Console.WriteLine("\n*** VIDEO INFO ***");
        Console.WriteLine($"Title of the video: {_title}");
        Console.WriteLine($"Author And credits: {_author}");
        Console.WriteLine($"Lenght in seconds: {_lenght}");
        Console.WriteLine($"Number of comments: {GetCommentsCountAbout_video()}");
    }
  
    public void DisplayVideoComments()
    {
        Console.WriteLine("\n*** COMMENTS ***");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetUserName()}\n {comment.GetComment()}");
        }
    }
   
        public int GetCommentsCountAbout_video()
    {
        return _comments.Count();
    }

    public int GetLenghtfortime()
    {
        return _lenght;
    }
    public string GetAuthors()
    {
        return _author;
    }
    public string GetTitleofthevideo()
    {
        return _title;
    }

}