using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        List<Video> videos = new List<Video>() { video1, video2, video3 };

        video1.title = "The Beauty of Nature";
        video1.author = "J.R.R. Tolkien";
        video1.lengthInSeconds = 180;
        video1.comments = new List<Comments>();

        video1.comments.Add(new Comments("Alice", "Amazing video!"));
        video1.comments.Add(new Comments("Pedro", "Great video!"));
        video1.comments.Add(new Comments("Jack", "Really awesome!"));
        video1.comments.Add(new Comments("Amanda", "Congratulations!"));

        video2.title = "Harry Porter and the Sorcerer's Stone";
        video2.author = "Isac Asimov";
        video2.lengthInSeconds = 250;
        video2.comments = new List<Comments>();

        video2.comments.Add(new Comments("Alice", ":D"));
        video2.comments.Add(new Comments("Pedro", "Great!"));
        video2.comments.Add(new Comments("Jack", "Awesome!"));
        video2.comments.Add(new Comments("Amanda", "Congratulations!"));

        
        video3.title = "Narnia: The Lion, the Witch and the Wardrobe";
        video3.author = "C.S. Lewis";
        video3.lengthInSeconds = 600;
        video3.comments = new List<Comments>();

        video3.comments.Add(new Comments("Alice", "Amazing video!"));
        video3.comments.Add(new Comments("Pedro", "LOOOOOOL!"));
        video3.comments.Add(new Comments("Jack", "F"));
        video3.comments.Add(new Comments("Amanda", "WOOOOOO!"));
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Title: {video.title}");
            Console.WriteLine($"Length: {video.lengthInSeconds} seconds");
            video.displayAllComments();
            video.countComments();
            Console.WriteLine();
        }

        
    }
}