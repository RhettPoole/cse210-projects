using System.Collections.Generic;

public class Video
{
    // Set properties for the title, author, length, and a list to store all of the comments.
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    // Constructor so that we can later initialize the classes into the Program.cs file.
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method for adding comments to the list.
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        Comments.Add(comment);
    }

    // Method for counting the number of comments on the video.
    public int GetNumComments()
    {
        return Comments.Count;
    }
}