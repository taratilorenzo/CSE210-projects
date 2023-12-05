using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> _videos = new List<Video>();

        Video video1 = new Video("The Best Products","Laurence Gother", 180);
        Video video2 = new Video("The Best Results", "Emmanuel Vautier", 195);
        Video video3 = new Video("Good versus Bad", "Monique Chepa", 200);
        Video video4 = new Video("The cost of living and luxury", "Manu Papi", 240);

        Comment comment1 = new Comment("Napal12","I dont believe in it");
        Comment comment2 = new Comment("Nevermind2","is it me or this is awesome!");
        Comment comment3 = new Comment("Mon Amour_","I think i will try it somehow");
        Comment comment4 = new Comment("Lolo","scam scam scam");
        video1.StoreComments(comment1);
        video1.StoreComments(comment2);
        video1.StoreComments(comment3);
        video1.StoreComments(comment4);

        Comment comment5 = new Comment("Hamul54", "I tried it and it suck!");
        video2.StoreComments(comment5);

        Comment comment6 = new Comment("120Robot","Im positioning myself to Great");
        Comment comment7 = new Comment("AI_45","MMMMMM, that rocks man");
        video3.StoreComments(comment6);
        video3.StoreComments(comment7);

        Comment comment8 = new Comment("RichGuy","Luxury All day Baby");
        Comment comment9 = new Comment("PoorGuy","I dont know man, Its getting to expensive");
        Comment comment10 = new Comment("MiddleMan","Better learn some financial habits");
        Comment comment11 = new Comment("Alwaysthere","MoneyFlow is key my bro!");
        video4.StoreComments(comment8);
        video4.StoreComments(comment9);
        video4.StoreComments(comment10);
        video4.StoreComments(comment11);

        
        
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach(Video video in _videos)
        {
            video.DisplayVideo();
        }


    }
}