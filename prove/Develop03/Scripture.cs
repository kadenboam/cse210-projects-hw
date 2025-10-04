public class Scripture
{
    //Makes a list so we can store multiple scriptures
    private List<Reference> _scripture = new List<Reference>();

    public string HideVerseWords(List<string> HiddenWords, string Verse)
    {
        foreach (string k in HiddenWords)
        {
            bool check = Verse.Contains($" {k} ");
            if (check == true)
            {
                string underline = "";
                //Learned this from https://www.w3schools.com/cs/cs_for_loop.php to make sure I have the correct word spacing
                for (int underlineCount = k.Count(); underlineCount > 0; underlineCount = underlineCount - 1)
                {
                    underline = underline + "_";
                }
                //I was able to learn to use this one thanks to https://www.geeksforgeeks.org/c-sharp/string-replace-method-c-sharp/ it was vital to remove words this way.
                Verse = Verse.Replace($" {k} ", $" {underline} ");
            }
        }
        return Verse;
    }

    //For now, all this does is display a scripture. Later a input could be added to randomize the chosen scripture
    public void DisplayScripture()
    {
        _scripture[0].Display();
    }

    public List<Reference> GetScripture()
    {
        return _scripture;
    }

    //Used to be in program.cs, but moved here to keep the code more precise and clear
    public void DefScriptures()
    {
        Reference _scripture1 = new Reference("2 Nephi", 2, 3, 5, " 3 Wherefore, thy soul shall be blessed, and thou shalt dwell safely with thy brother, Nephi; and thy days shall be spent in the service of thy God. Wherefore, I know that thou art redeemed, because of the righteousness of thy Redeemer; for thou hast beheld that in the fulness of time he cometh to bring salvation unto men. 4 And thou hast beheld in thy youth his glory; wherefore, thou art blessed even as they unto whom he shall minister in the flesh; for the Spirit is the same, yesterday, today, and forever. And the way is prepared from the fall of man, and salvation is free. 5 And men are instructed sufficiently that they know good from evil. And the law is given unto men. And by the law no flesh is justified; or, by the law men are cut off. Yea, by the temporal law they were cut off; and also, by the spiritual law they perish from that which is good, and become miserable forever. ");
        Reference _scripture2 = new Reference("1 Nephi", 3, 7, " 7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ");
        Reference _scripture3 = new Reference("1 Nephi", 4, 6, " 6 And I was led by the Spirit, not Knowing beforehand the things which I should do. ");

        //Add that scripture to the list
        GetScripture().Add(_scripture1);
        GetScripture().Add(_scripture2);
        GetScripture().Add(_scripture3);
    }
}