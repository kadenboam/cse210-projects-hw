using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        //This is used to make a new list to keep track of all the scripture, in case we wanted more list (as in the BoM or the PoGP)
        Scripture _list1 = new Scripture();
        //Using the presets from the Reference file, we can manipulate the data that is private
        _list1.DefScriptures();

        //Now we just display the scripture. Randomize the sellection later in Scripture.cs
        //_list1.DisplayScripture();
        //I decided to randomize it here
        Random random = new Random();
        int randomScripture = random.Next(0, _list1.GetScripture().Count);
        string verse = _list1.GetScripture()[randomScripture].GetVerse();

        //Words will always follow suit of the random scripture since it recieves verse whcich is already a random scripture.
        Words _word1 = new Words(verse);
        //_word1.DisplayWords();

        //Word Removal Test
        _word1.HideWords();
        //_word1.DisplayWords();

        //Word in verse removal test
        //_list1.DisplayScripture();
        //Console.WriteLine(_list1.HideVerseWords(_word1.GetHiddenWords(), _scripture1.GetVerse()));

        //Revealing words test
        _word1.RevealWords();
        //_list1.DisplayScripture();
        //Console.WriteLine(_list1.HideVerseWords(_word1.GetHiddenWords(), _scripture1.GetVerse()));

        //Assignment testing
        string option = "";
        int second = 1;
        do
        {
            Console.Clear();
            //Learned how to show special characters from the special character tab on W3Schools
            Console.WriteLine("Type \'quit\' to quit, \'r\' to reveal words, or just hit enter to hide words");
            Console.WriteLine("Scripture memorizer: ");
            _list1.GetScripture()[randomScripture].Display();
            Console.WriteLine(_list1.HideVerseWords(_word1.GetHiddenWords(), _list1.GetScripture()[randomScripture].GetVerse()));
            Console.WriteLine("");
            //This is to see the list of words that are shown, for debugging purposes
            //foreach (string k in _word1.GetWord()) { Console.Write($"{k} "); }
            option = Console.ReadLine();

            //Options for revealing or hiding
            if (option == "r") { _word1.RevealWords(); }
            else { _word1.HideWords(); }

            //To end the program if all words are hidden
            int endCall = _word1.GetWord().Count();
            if (endCall == 0 & second == 0) { option = "quit"; }
            else if (endCall == 0) { second = 0; }
        } while (option != "quit");
    }
}