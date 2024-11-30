using System;
using System.Collections.Generic;
// resources
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0
// https://www.w3schools.com/cs/cs_arrays.php
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "CodeAcademy", 75000);
        video1._comments.Add(new Comment("Ben","Great explanation!"));
        video1._comments.Add(new Comment("Daniel", "Very helpful, thanks heaps."));
        video1._comments.Add(new Comment("Carl", "I have much to learn, looking forward for the next tutorial!"));
        video1._comments.Add(new Comment("Alice", "Can't wait to learn how to use C# for gaming haha"));

        Video video2 = new Video("Top 10 Programming Languages", "Tech Guru", 850);
        video2._comments.Add(new Comment("Rafael", "Python should be number one!"));
        video2._comments.Add(new Comment("Frank","I didn't know about GoLang."));
        video2._comments.Add(new Comment("Jerald", "Thanks! Time to learn C++"));
        video2._comments.Add(new Comment("Raniel", "Can you do Top 10 Websites or resources to learn these languages?"));

        Video video3 = new Video("C# Object-Oriented Programming", "DevWorld", 1599);
        video3._comments.Add(new Comment("Zues", "OOP is sweeeet!"));
        video3._comments.Add(new Comment("Troy","This was super helpful, thanks!"));
        video3._comments.Add(new Comment("Kosei", "Awesome! Please do a separate video teaching about the principle of Encapsulation."));
        video3._comments.Add(new Comment("Ron", "Finally understood OOP. Any recommended projects to start with?"));

        // add video to a list
        List<Video> videos = new List<Video> {video1, video2, video3};

        // display details for each video
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}