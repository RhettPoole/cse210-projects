using System.Collections.Generic;

public class Comment
{
    // Set properties for the name and text of the author of the comment and what they write.
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to later initialize into the Program.cs file
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}