using System;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("");
        Activities activities = new Activities("This Mindfullness activity will help you take time out of your day to relax and think. ", "You did great! If you are ready for another session, lets begin! ");
        Console.Write(activities.StartMessage());        

        //Initializing Breathing
        BreathingActivity breathing = new BreathingActivity(activities.StartMessage(), activities.EndMessage(), "This is a breathing activity, you will take your time taking breaths in, then out during the time limit you have set. Clear your mind and focus as we begin the activity.");
        Console.WriteLine("");

        //Initializing Reflection
        ReflectionActivity reflection = new ReflectionActivity(activities.StartMessage(), activities.EndMessage(), "This is a reflection activity, where you will be given a prompt and then followup questions to reflect on untill the session is done.");

        //Initializing Listing
        ListingActivity listing = new ListingActivity(activities.StartMessage(), activities.EndMessage(), "This is a listing activity, where you are given a prompt and have a certain amount of time to list everthing you can about the prompt.");

        //After some trouble getting animation time to work, seting the time differently was needed
        activities.SetDateTime(activities.GetTime());

        //Loop for repetitive program
        string userInput = "0";
        do
        {
            //Innitialized the Time by loading them from the save file
            string[] lines = System.IO.File.ReadAllLines("Save.txt");
            for (int i = 0; i < lines.Length;)
            {
                activities.breathingTime = int.Parse(lines[i++].Substring(22));
                activities.reflectionTime = int.Parse(lines[i++].Substring(23));
                activities.listingTime = int.Parse(lines[i++].Substring(20));
            }

            //This is the menu for the different Activity selections
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a activity or quit: ");
            userInput = Console.ReadLine();

            //Does the different activities based on user choice
            if (userInput == "1")
            {
                //Does the complete breathing activity with this function alone, while also saving the time spent on breathing
                using (StreamWriter outputFile = new StreamWriter("Save.txt"))
                {
                    outputFile.WriteLine($"Breathing Time Spent: {activities.breathingTime + breathing.BreathingDescription()}");
                    outputFile.WriteLine($"Reflection Time Spent: {activities.reflectionTime}");
                    outputFile.WriteLine($"Listing Time Spent: {activities.listingTime}");
                }
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }
            if (userInput == "2")
            {
                Console.Clear();
                //Does the complete reflection activity, while also saving the time spent
                using (StreamWriter outputFile = new StreamWriter("Save.txt"))
                {
                    outputFile.WriteLine($"Breathing Time Spent: {activities.breathingTime}");
                    outputFile.WriteLine($"Reflection Time Spent: {activities.reflectionTime + reflection.ReflectionDescription()}");
                    outputFile.WriteLine($"Listing Time Spent: {activities.listingTime}");
                }
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }
            if (userInput == "3")
            {
                Console.Clear();

                //This does the listing activity and save the ammount of time spen on it.
                using (StreamWriter outputFile = new StreamWriter("Save.txt"))
                {
                    outputFile.WriteLine($"Breathing Time Spent: {activities.breathingTime}");
                    outputFile.WriteLine($"Reflection Time Spent: {activities.reflectionTime}");
                    outputFile.WriteLine($"Listing Time Spent: {activities.listingTime + listing.ListingDescription()}");
                }
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }
            if (userInput == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Here is the time spent in each activity: ");
                Console.WriteLine("");
                for (int i = 0; i < lines.Length;)
                {
                    Console.WriteLine(lines[i++]);
                    Console.WriteLine(lines[i++]);
                    Console.WriteLine(lines[i++]);
                }
                Console.WriteLine("");
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }

        } while (userInput != "5");

        //Wrap up with concluding words
        Console.Clear();
        Console.WriteLine("You did great today. Comeback if you would like to do another session with us, but untill then, namaste.");
    }
}