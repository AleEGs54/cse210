using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(title: "Unboxing the Latest Smartphone: Features and First Impressions!", author: "TechSavvyGadgeteer", length: 10.5f);
        Video video2 = new Video(title: "Top 10 Kitchen Gadgets You Need in 2024!", author: "CulinaryWhiz", length: 30.12f);
        Video video3 = new Video(title: "The Ultimate Fitness Challenge: Can I Transform My Body in 30 Days?", author: "FitJourneyGuru", length: 40f);
        Video video4 = new Video(title: "Exploring the Best Tech Gifts for the Holidays 2024!", author: "GadgetGiftGuru", length: 8.33f);

        // Comments for vid1
        video1.StoreComment(name: "Joe the fan", text: "I can't believe how sleek the Galaxy Z Flip 5 looks! Definitely considering upgrading my current model.");
        video1.StoreComment(name: "Marta Matts", text: "Great review! I appreciate the detailed comparison with the iPhone 14.");
        video1.StoreComment(name: "Lazy Compiles", text: "The camera quality of the Pixel 8 seems incredible! Can't wait to see more sample photos.");

        // Comments for vid2
        video2.StoreComment(name: "Sue PErmann", text: "I've been looking for a good blender! Which one would you recommend from this list? Maybe the Ninja BN701?");
        video2.StoreComment(name: "Anita Bath", text: "Love the Instant Pot Duo 7-in-1! It's a game changer for meal prep.");
        video2.StoreComment(name: "Justin Case", text: "Can you do a video on how to use these gadgets effectively? Would love to see that with the Air Fryer XL!");
        video2.StoreComment(name: "Willy Nilly", text: "Just ordered the KitchenAid Stand Mixer after watching this! Excited to try it out.");

        // Comments for vid3
        video3.StoreComment(name: "Chris P. Bacon", text: "Motivated by your journey! What supplements are you using for recovery? Is it Optimum Nutrition Gold Standard?");
        video3.StoreComment(name: "Phil McCracken", text: "I see you're using Nike Air Zoom gear! It looks amazing and seems to perform well.");
        video3.StoreComment(name: "Ben Dover", text: "Could you share your meal plan? I need some ideas to go along with my workouts!");
        video3.StoreComment(name: "Barb Dwyer", text: "I love how you incorporate different products. It keeps things fresh and exciting!");

        // Comments for vid4
        video4.StoreComment(name: "Don Keigh", text: "These suggestions are spot on! I'm definitely getting the Apple AirPods Pro for my partner.");
        video4.StoreComment(name: "Pat Myback", text: "Thanks for including budget options! It's tough finding good tech gifts that don't break the bank, like the Anker Power Bank.");
        video4.StoreComment(name: "Bea O'Problem", text: "What do you think about the Fitbit Charge 5? Is it worth it for gifting?");

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayAll());
        }
    }
}