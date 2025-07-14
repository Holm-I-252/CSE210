using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "John Doe", 300);
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Very informative, thanks!");
        Comment comment3 = new Comment("Charlie", "I learned a lot!");
        Comment comment4 = new Comment("Diana", "Looking forward to more content!");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        Video video2 = new Video("Python Basics", "Jane Smith", 450);
        Comment comment5 = new Comment("Eve", "Python is awesome!");
        Comment comment6 = new Comment("Frank", "Can't wait to try this out!");
        Comment comment7 = new Comment("Grace", "This helped me understand the basics!");

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        Video video3 = new Video("JavaScript for Beginners", "Mike Johnson", 600);
        Comment comment8 = new Comment("Hannah", "JavaScript is so versatile!");
        Comment comment9 = new Comment("Ian", "Great introduction to JS!");
        Comment comment10 = new Comment("Jack", "I love the examples used here!");
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        var video1Info = video1.GetVideoInfo();
        var video2Info = video2.GetVideoInfo();
        var video3Info = video3.GetVideoInfo();
        
        var videos = new[] { video1, video2, video3 };

        foreach (var video in videos)
        {
            var videoInfo = video.GetVideoInfo();
            Console.WriteLine($"Video Title: {videoInfo.Item1}");
            Console.WriteLine($"Uploader: {videoInfo.Item2}");
            Console.WriteLine($"Length: {videoInfo.Item3} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in videoInfo.Item4 ?? Array.Empty<Comment>())
            {
                var commentInfo = comment.GetCommentInfo();
                Console.WriteLine($"- {commentInfo.Item1}: {commentInfo.Item2}");
            }
        }
    }
}