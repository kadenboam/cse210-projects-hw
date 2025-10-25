using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

        //Defines each video and their respective comments
        Video video1 = new Video("I Spent 3 Years Engineering my Water Bottle", "Zwigs", 10.42);
        video1.comment.Add(new Comment("solidwild", "i think your video editing skills are better than engineering skills"));
        video1.comment.Add(new Comment("christiancarr9868", "you're insane making this bottle in tinkerCAD"));
        video1.comment.Add(new Comment("MedicMainDave", "\"Simplicity is the ultimate sophistication\""));
        video1.comment.Add(new Comment("Ballacha", "bro hasn't been to one vietnamese restaurant or yum cha place in his life lol. the thermos they use to pour tea is pretty much what this guy is trying to reinvent."));

        Video video2 = new Video("CAMERAMAN (Animatic Pilot)", "montanamations", 4.06);
        video2.comment.Add(new Comment("Luna64-k4v", "I can't believe Green Goblin got his ___ beat by a cyan haired dude who speaks in Animal Crossing."));
        video2.comment.Add(new Comment("galxcticpredator2510", "\"the cameraman never dies\" is a phrase so cold it finally got animated lol"));
        video2.comment.Add(new Comment("BumB0oo-0_0", "respect to the camera man who record this camera man face-purple-wide-eyesglasses-purple-yellow-diamondglasses-purple-yellow-diamondglasses-purple-yellow-diamondglasses-purple-yellow-diamondpenguin-blue-waving-tearpenguin-blue-waving-tearpenguin-blue-waving-tearface-blue-smilingface-blue-smiling"));
        video2.comment.Add(new Comment("doctorspiders", "Cameran man: must not interfere    Villain: interferes with CM life    Camera man: AW H*** NAH"));

        Video video3 = new Video("Every Level of Engineering in 15 Minutes", "Engineering Insiders", 15.38);
        video3.comment.Add(new Comment("paulBIOgeek", "Chemical Engineer masquerading as an Associate Director of Program Management at a large pharma company. Quite a fantastic career path"));
        video3.comment.Add(new Comment("bingzhewho", "0:28 hope you dont have to hold your bladder"));
        video3.comment.Add(new Comment("tchuitcheuyowan", "Great video as usual! Thank you very much"));
        video3.comment.Add(new Comment("matthewmast485", "The corporate climb is never this linear"));

        Video video4 = new Video("Megamind From Metro Man's POV Is Hilarious", "Calobi Productions", 8.05);
        video4.comment.Add(new Comment("RHaenJarr", "You can either die a hero or live long enough to become Markiplier"));
        video4.comment.Add(new Comment("bfranciscop", "I hadn't noticed how important to his character it is that he's bad at playing the guitar. It means he has to work at it, he has to commit, practice and improve. It reminds me of Mob Psycho 100's story, who chooses similar trials."));
        video4.comment.Add(new Comment("arionofotherworld", "Metro Man was a superhero almost 24/7 for years, that would drain anyone. If he had used a secret identity and just took time off he might have been happier in the role."));
        video4.comment.Add(new Comment("RussianFederation71", "I mean he got tired of doing it over and over again so you can't blame him"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        //Itteraes through each video
        foreach (var content in videos)
        {
            content.DisplayVideo();
        }
        //All these videos and comments are respectivley each authors creation. 
    }
}