public class Scripture
{
    //Makes a list so we can store multiple scriptures
    public List<Reference> _scripture = new List<Reference>();

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
}