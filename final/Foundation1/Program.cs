class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author A", 120),
            new Video("Video 2", "Author B", 140),
            new Video("Video 3", "Author C", 160)
        };

        
        videos[0].AddComment(new Comment("User1", "Great video!"));
        videos[0].AddComment(new Comment("User2", "Thanks for the info."));
        videos[1].AddComment(new Comment("User3", "Very informative."));
        videos[2].AddComment(new Comment("User4", "Loved it!"));
        videos[2].AddComment(new Comment("User5", "Please make more."));

        
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}