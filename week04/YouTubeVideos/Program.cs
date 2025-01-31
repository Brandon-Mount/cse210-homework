using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videos = new List<Video>();
        
        // Creating videos
        Video video1 = new Video("Exploring C#", "John Doe", 600);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Can you make a follow-up?");
        videos.Add(video1);
        
        Video video2 = new Video("Introduction to AI", "Jane Smith", 1200);
        video2.AddComment("Dave", "Mind-blowing stuff!");
        video2.AddComment("Eve", "AI is the future!");
        video2.AddComment("Frank", "Awesome video!");
        videos.Add(video2);
        
        Video video3 = new Video("How to Cook Pasta", "Chef Luigi", 900);
        video3.AddComment("Grace", "Delicious recipe!");
        video3.AddComment("Hank", "I tried it, turned out great!");
        video3.AddComment("Ivy", "Simple and easy to follow.");
        videos.Add(video3);
        
        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}