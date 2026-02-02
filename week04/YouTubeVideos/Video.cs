public class Video
{
    public string title;
    public string author;
    public int lengthInSeconds;
    public List<Comments> comments;

    public void addComments(Comments comment)
    {
        comments.Add(comment);
    }

    public void displayAllComments()
    {
        foreach (Comments comment in comments)
        {
            Console.WriteLine($"{comment.name}: {comment.commentText}");
        }
    }

    public void countComments()
    {
        Console.WriteLine($"This video has {comments.Count} comments.");
    }
}