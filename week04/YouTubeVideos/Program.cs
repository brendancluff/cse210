using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold videos
        List<Video> videos = new List<Video>();

        // First video
        Video video1 = new Video("Learning C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "Could you cover loops next?"));
        videos.Add(video1);

        // Second video
        Video video2 = new Video("Top 10 Coding Tips", "DevGuru", 480);
        video2.AddComment(new Comment("Dave", "Tip #3 saved me hours."));
        video2.AddComment(new Comment("Emma", "Love this channel!"));
        video2.AddComment(new Comment("Frank", "Can you make a part 2?"));
        videos.Add(video2);

        // Third video
        Video video3 = new Video("Debugging Like a Pro", "TechTalks", 720);
        video3.AddComment(new Comment("Grace", "Debugging is actually fun now!"));
        video3.AddComment(new Comment("Henry", "The visuals were spot on."));
        video3.AddComment(new Comment("Isabel", "This should be required for beginners."));
        videos.Add(video3);

        // Display info for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
