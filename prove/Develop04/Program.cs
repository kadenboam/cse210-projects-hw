using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("");
        Activities activities = new Activities("This Mindfullness activity will help you take time out of your day to relax and think. How much time (in seconds) would you like it to be? ", "You did great today. Comeback if you would like to do another session with us, but untill then, namaste.");
        Console.Write(activities.StartMessage());
        activities.SetTime(int.Parse(Console.ReadLine()));
        activities.GetAnimation();

        //Initializing Breathing
        BreathingActivity breathing = new BreathingActivity(activities.StartMessage(), activities.EndMessage(), "This is a breathing activity, you will take your time taking breaths in, then out during the time limit you have set. Clear your mind and focus as we begin the activity.");
        Console.WriteLine("");

        //After some trouble getting animation time to work, seting the time differently was needed
        activities.SetDateTime(activities.GetTime());

        //Does the complete breathing activity with this function alone
        breathing.BreathingDescription(activities.GetTime());

        //Wrap up with concluding words
        Console.Clear();
        Console.WriteLine(activities.EndMessage());
    }
}