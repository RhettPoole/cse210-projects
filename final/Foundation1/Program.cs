using System;

class Program
{
    static void Main(string[] args)
    {
        // Create and initialize the videos.
        Video video1 = new Video("George Lucas", "The Empire Strikes Back", 120);
        video1.AddComment("Yoda", "Try not. Do or do not. There is no try.");
        video1.AddComment("Princess Leia", "I'd just as soon kiss a wookie.");

        Video video2 = new Video("George Lucas", "A New Hope", 360);
        video2.AddComment("Obi-Wan Kenobi", "Your eyes can deceive you; don't trust them.");
        video2.AddComment("Han Solo", "Great, kid, don't get cocky.");
        video2.AddComment("C-3PO","Don't call me a mindless philosopher, you overweight glob of grease.");

        Video video3 = new Video("George Lucas", "The Mandalorian", 500);
        video3.AddComment("Mando", "I'm a Mandalorian. Weapons are part of my religion.");


        // Initialize list, add videos to list.
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumComments());
            
            //Display comments
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
            }
        }

    }
}