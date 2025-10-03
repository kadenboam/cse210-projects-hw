using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        //This is used to make a new list to keep track of all the scripture, in case we wanted more list (as in the BoM or the PoGP)
        Scripture _list1 = new Scripture();
        //Using the presets from the Reference file, we can manipulate the data that is private
        Reference _scripture1 = new Reference("2 Nephi", 2, 3, 5, " 3 Wherefore, thy soul shall be blessed, and thou shalt dwell safely with thy brother, Nephi; and thy days shall be spent in the service of thy God. Wherefore, I know that thou art redeemed, because of the righteousness of thy Redeemer; for thou hast beheld that in the fulness of time he cometh to bring salvation unto men. 4 And thou hast beheld in thy youth his glory; wherefore, thou art blessed even as they unto whom he shall minister in the flesh; for the Spirit is the same, yesterday, today, and forever. And the way is prepared from the fall of man, and salvation is free. 5 And men are instructed sufficiently that they know good from evil. And the law is given unto men. And by the law no flesh is justified; or, by the law men are cut off. Yea, by the temporal law they were cut off; and also, by the spiritual law they perish from that which is good, and become miserable forever. ");
        //Add that scripture to the list
        _list1._scripture.Add(_scripture1);

        //Now we just display the scripture. Randomize the sellection later in Scripture.cs
        //_list1.DisplayScripture();
        string verse = _list1._scripture[0].GetVerse();

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
            _list1.DisplayScripture();
            Console.WriteLine(_list1.HideVerseWords(_word1.GetHiddenWords(), _scripture1.GetVerse()));
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