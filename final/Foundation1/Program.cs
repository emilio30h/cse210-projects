using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a video
        Video video = new Video
        {
            Title = "Introduction to Programming",
            Author = "John Doe",
            Length = 120,
            Comments = new List<Comment>()
        };

        // Add comments to the video
        video.Comments.Add(new Comment { Name = "User1", Text = "Great video!" });
        video.Comments.Add(new Comment { Name = "User2", Text = "Very informative." });
        video.Comments.Add(new Comment { Name = "User3", Text = "I learned a lot." });

        // Display video details and comment count
        Console.WriteLine("Video Details:");
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.Length} minutes");
        Console.WriteLine($"Comment count: {video.GetCommentCount()}");

        // Display comments
        Console.WriteLine("\nComments:");
        foreach (Comment comment in video.Comments)
        {
            Console.WriteLine($"Name: {comment.Name}");
            Console.WriteLine($"Text: {comment.Text}");
            Console.WriteLine();
        }
    }
}