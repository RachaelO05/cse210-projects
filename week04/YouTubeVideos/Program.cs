using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("THRIFT SUMMER 2026 TRENDS WITH ME", "Sydnee Zora", 1745);
        video1.addComment(new Comment("@ivylamitina", "the first black skirt you put on made me gasp haha!! very lucky this time around. I loved it all"));
        video1.addComment(new Comment("@abbieallen", "Omg I was obsessed with the black polka dot shirt w the bow in the back"));
        video1.addComment(new Comment("@cleliamandler766", "omg the green pants 😍"));
        video1.addComment(new Comment("@milopilomorot", "The first skirt you tried on could maybe also work as a dress / top 💕"));
        videos.Add(video1);

        Video video2 = new Video("$1 vs $1 Million Magician", "Kevin Langue", 2894);
        video2.addComment(new Comment("@catitaylist", "stoppp all the magicians helping out number 5 was so sweet, also he did such a great job w such little practice"));
        video2.addComment(new Comment("@K-pop_penguin", "That lottery ticket had me contemplating life for a sec"));
        video2.addComment(new Comment("@alexs", "Genuinely one of the most entertaining videos ever"));
        videos.Add(video2);

        Video video3 = new Video("Inside Olivia Rodrigo’s Vintage Fendi Bag | In the Bag | Vogue", "Vogue", 675);
        video3.addComment(new Comment("@ashnashesngs", "Thanks Vogue for bringing Olivia back, we missed herrrrr"));
        video3.addComment(new Comment("@parinitaa18", "i love olivia ‘s personality, it feels so real, fresh and unique as compared to other celebrities"));
        video3.addComment(new Comment("@SencAna-0r0", "The hair is everything.She just gets prettier and prettier each time I see her!!"));
        video3.addComment(new Comment("@aliewood31", "she's SO well-spoken and she uses vocabulary i don't hear often and im obsessed with that"));
        videos.Add(video3);

        Video video4 = new Video("Millie Bobby Brown Petitions Da Bomb While Eating Spicy Wings | Hot Ones", "First We Feast", 1507);
        video4.addComment(new Comment("@b51uck", "ha millie's responses to the animal quiz during the bomb were HILARIOUS"));
        video4.addComment(new Comment("@domncskelton", "Her chaotic energy really is a giggle."));
        video4.addComment(new Comment("@michaelr", "Her pop quiz part is hilarious"));
        video4.addComment(new Comment("@Boots", "Props to Louis coming in and  crushing those two wings."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.numberOfComments()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }

}