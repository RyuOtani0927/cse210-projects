using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videoList = new();

        Video video1 = new Video("Python explained", "John Smith", 600);
        video1.AddComment("Tayler", "Great!");
        video1.AddComment("Sophia Bennett", "Nice.");
        video1.AddComment("Emma Richardson","Thank you for the video!");
        videoList.Add(video1);

        Video video2 = new Video("C# Lesson", "Liam Carter", 1200);
        video2.AddComment("Noah Brooks", "This was super helpful!");
        video2.AddComment("Oliver Hayes", "This is exactly what I needed!");
        video2.AddComment("James Reed", "Great lesson!");
        videoList.Add(video2);

        Video video3 = new Video("How to use excel", "Mia Foster", 2400);
        video3.AddComment("Isabella Parker", "I wish I found this video earlier.");
        video3.AddComment("Amelia Gray", "You make it so easy to follow!");
        video3.AddComment("Lucas Turner", "I could follow along easily.");
        videoList.Add(video3);
        
        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
        }
    }
}