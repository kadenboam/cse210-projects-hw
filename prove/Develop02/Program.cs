using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        //Initializing eveything
        Console.WriteLine("Hello Develop02 World!");
        List<string> question = new List<string> { "How was your day?", "What was something fun you did?", "Who did you talk to?", "How was the weather today?", "What did you eat today?", "What are your plans for the future", "What is different from yesterday?" };
        int userInput = 0;
        Journal journal = new Journal();

        //Runs until the quit mode is entered
        do
        {
            DisplayMenu();
            do
            {
                Console.Write("Which option will you choose? ");
                string input = Console.ReadLine();
                //Have to make sure the inputs work right
                while (!int.TryParse(input, out userInput))
                {
                    Console.Write("Invalid input. Please enter a number: ");
                    input = Console.ReadLine();
                }
            } while (userInput > 6 || userInput < 1); //Checks for real input choice

            //Simple functions
            if (userInput == 1)
            {
                NewEntry(question, journal);
            }

            else if (userInput == 2)
            {
                journal.DisplayAllEntries();
            }

            else if (userInput == 3)
            {
                journal.DisplayMiracles();
            }

            //Slightly complex functions
            else if (userInput == 4)
            {
                Console.Write("What file will you save it to? ");
                string filename = Console.ReadLine();
                SaveJournal(filename, journal);
            }

            else if (userInput == 5)
            {
                Console.Write("What file will you load it from? ");
                string filename = Console.ReadLine();
                LoadJournal(filename, journal);
            }
            else if (userInput == 6)
            {
                Console.Write("Exiting the program. ");
            }

            //Different functions used in this program
            static void DisplayMenu()
            {
                Console.WriteLine("");
                Console.WriteLine("Select one of the following options: ");
                Console.WriteLine("1.Write ");
                Console.WriteLine("2.Display ");
                Console.WriteLine("3.Display Miracles");
                Console.WriteLine("4.Save Journal");
                Console.WriteLine("5.Load Journal");
                Console.WriteLine("6. Quit");
            }

            static void NewEntry(List<string> d, Journal e)
            {
                Random randomGenerator = new Random();
                Entry entry1 = new Entry();
                int k = randomGenerator.Next(0, d.Count());
                entry1._prompt = d[k];
                Console.WriteLine("");
                Console.WriteLine($"Prompt: {entry1._prompt}");
                Console.Write("Response: ");
                entry1._response = Console.ReadLine();
                Console.Write("Date: ");
                entry1._date = Console.ReadLine();

                //Some Extra Features to more personalize the Journal
                Console.Write("Title: ");
                entry1._title = Console.ReadLine();

                //Experimental, as it now works after fixing the class program
                Console.Write("Mood: ");
                entry1._mood = Console.ReadLine();
                Console.Write("Rating (1-5): ");
                string input = Console.ReadLine();
                int output;
                //Double checks compatability
                while (!int.TryParse(input, out output))
                {
                    Console.Write("Invalid input. Please enter a number: ");
                    input = Console.ReadLine();
                }
                entry1._rating = output;

                //Miracles have their own seperate display function if desired
                Console.Write("Miracle of the day: ");
                entry1._miracles = Console.ReadLine();
                Console.Write("Miracle Title: ");
                entry1._miracleTitles = Console.ReadLine();
                e._entries.Add(entry1);
            }

            static void SaveJournal(string k, Journal b)
            {
                using (StreamWriter outputFile = new StreamWriter(k))
                {
                    // Writes each line of the journal into the file
                    foreach (Entry a in b._entries)
                    {
                        outputFile.WriteLine("");
                        outputFile.WriteLine($"Date: {a._date}");
                        outputFile.WriteLine($"Title: {a._title}");
                        outputFile.WriteLine($"Prompt: {a._prompt}");
                        outputFile.WriteLine($"Response: {a._response}");
                        outputFile.WriteLine($"Mood: {a._mood}");
                        outputFile.WriteLine($"Rating: {a._rating}");
                        outputFile.WriteLine("");
                        outputFile.WriteLine($"Miracle Title: {a._miracles}");
                        outputFile.WriteLine($"Miracle: {a._miracleTitles}");
                    }
                }
            }
            static void LoadJournal(string k, Journal a)
            {
                string[] lines = System.IO.File.ReadAllLines(k);
                
                //Little more tricky to figure out, takes each line in order to add to Journal
                for (int i = 0; i < lines.Length - 8;)
                {
                    // Skip blank line before entry
                    i++;
                    Entry entry = new Entry();
                    entry._date = lines[i++].Substring(6);
                    entry._title = lines[i++].Substring(7);
                    entry._prompt = lines[i++].Substring(8);
                    entry._response = lines[i++].Substring(10);
                    entry._mood = lines[i++].Substring(6);
                    entry._rating = int.Parse(lines[i++].Substring(8));
                    // Skip blank line
                    i++;
                    entry._miracles = lines[i++].Substring(15);
                    entry._miracleTitles = lines[i++].Substring(9);
                    a._entries.Add(entry);
                }
            }
        } while (userInput != 6);
}
}