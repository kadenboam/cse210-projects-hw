using System;
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
            //This is the menu for the different Activity selections
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a activity or quit: ");
            userInput = Console.ReadLine();

            //Does the different activities based on user choice
            if (userInput == "1")
            {
                //Does the complete breathing activity with this function alone
                breathing.BreathingDescription();
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }
            if (userInput == "2")
            {
                Console.Clear();
                //Does the complete reflection activity
                reflection.ReflectionDescription();
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }
            if (userInput == "3")
            {
                Console.Clear();
                listing.ListingDescription();
                Console.WriteLine("");
                Console.WriteLine(activities.EndMessage());
                Console.WriteLine("");
                activities.GetAnimation("$");
            }

        } while (userInput != "4");

        //Wrap up with concluding words
        Console.Clear();
        Console.WriteLine("You did great today. Comeback if you would like to do another session with us, but untill then, namaste.");
    }
}