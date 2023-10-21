public class Comment
{
    private string _userName;
    private string _comments;

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comments = comment;

    }
    //GETTERS
    public string GetUserName()
    {
        return _userName;
    }
    public string GetComment()
    {
        return _comments;
    }
}