using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "Code Master",
            1800);

        video1.AddComment(new Comment(
            "Alice",
            "Great tutorial!"
        ));

        video1.AddComment(new Comment(
            "Bob",
            "Very helpful."
        ));

        video1.AddComment(new Comment(
            "Charlie",
            "Thanks for sharing!"
        ));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Python Basics",
            "Tech School",
            1500);

        video2.AddComment(new Comment(
            "David",
            "Excellent explanation."
        ));

        video2.AddComment(new Comment(
            "Emma",
            "I learned a lot."
        ));

        video2.AddComment(new Comment(
            "Lucas",
            "Keep making videos!"
        ));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Object-Oriented Programming",
            "BYU Coding",
            2200);

        video3.AddComment(new Comment(
            "Sarah",
            "Now I understand classes."
        ));

        video3.AddComment(new Comment(
            "John",
            "Very clear lesson."
        ));

        video3.AddComment(new Comment(
            "Mike",
            "Awesome content!"
        ));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "Git and GitHub Tutorial",
            "Programming Hub",
            1600);

        video4.AddComment(new Comment(
            "Sophia",
            "Git finally makes sense!"
        ));

        video4.AddComment(new Comment(
            "Daniel",
            "This helped me with my class."
        ));

        video4.AddComment(new Comment(
            "Grace",
            "Excellent tutorial."
        ));

        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}