using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        //The two company addresses, could be changed for a list and put into the other classes if needed
        Address address1 = new Address("2020 Solara Loop NE", "Albuquerque", "New Mexico", "Mexico");
        Address address2 = new Address("9485 Elmherst Dr.", "South Jordan", "Utah", "United states");

        OutdoorGatherings gathering1 = new OutdoorGatherings("Bowling", "Get a strike man", "09/27/2026", 730, "Sunny");
        Lectures lecture1 = new Lectures("How to get it done", "A lecture about the book, getting things done", "02/18/2026", 515, 150, "Josh Mckartin");
        Receptions reception1 = new Receptions("Josh and Carla", "The recpetion of Carla and Josh, and your invited.", "11/04/2025", 1245, "Yes");

        gathering1.DisplaySimple("OutdoorGatherings");
        lecture1.DisplaySimple("Lecture");
        reception1.DisplaySimple("Reception");

        Console.WriteLine();
        Console.WriteLine(gathering1.DisplayOutdoorGathering(address1.GetAddress()));

        Console.WriteLine();
        Console.WriteLine(lecture1.DisplayLecture(address2.GetAddress()));

        Console.WriteLine();
        Console.WriteLine(reception1.DisplayReception(address2.GetAddress()));
    }
}