using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Video 1", "Winky D", 120);
        v1.AddComment("Tonie", "Great video!");
        v1.AddComment("Mapancho", "I agree, you are the goat!");

        Video v2 = new Video("Video 2", "Willy Kafula", 180);
        v2.AddComment("Craig", "Thanks for sharing! It was a piece of art.");

        Video v3 = new Video("Video 3", "Jah Master", 90);
        v3.AddComment("Grace", "I learned a lot from this video. We need more like this!");

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine("Title: " + v.Title);
            Console.WriteLine("Author: " + v.Author);
            Console.WriteLine("Length: " + v.Length + " seconds");
            Console.WriteLine("Number of comments: " + v.GetNumberOfComments());

            foreach (Comment c in v.Comments)
            {
                Console.WriteLine("- " + c.CommenterName + ": " + c.Text);
            }

            Console.WriteLine(); 
        }
    }
}