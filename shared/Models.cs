namespace shared;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string AuthorName { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Upvotes { get; set; }
    public int Downvotes { get; set; }
    public int ThreadId { get; set; }
    public Thread Thread { get; set; }
}


public class Thread
{

    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; } // Can be a URL or text
    public DateTime CreatedAt { get; set; }
    public string AuthorName { get; set; }
    public List<Comment> Comments { get; set; } = new();
    public int Upvotes { get; set; }
    public int Downvotes { get; set; }
}

public class Vote
{
    public int Id { get; set; }
    public int ThreadId { get; set; }
    public int CommentId { get; set; }
    public bool IsUpvote { get; set; }
}