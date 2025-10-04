public class Words
{
    //Took me a second to figure out, after reviewing prep4 program under the prep file

    private List<string> _words = new List<string>();
    private List<string> _hiddenWords = new List<string>();

    //Ater evaluation, arrays were deamed better for this task: W3Schools example -> string[] words = { "Hello", "Goodbye", "What" };
    //string[] words = {}; Limitations were found with the array, Going back to lists

    public Words(string Verse)
    {
        /* //The initial Approach: 
        foreach (k in Verse)
        {
            words[k] = Verse[k];
            
        }
        */
        //After researching better alternatives, found one that can split strings into words (by splitting strings with certain characters)
        string[] array = Verse.Split(" ");
        foreach (string k in array)
        {
            //Found a solution to stop duplicates at https://stackoverflow.com/questions/3435089/how-to-check-if-object-already-exists-in-a-list , then modified it to my needs
            bool check = _words.Contains(k);
            if (check == false)
            {
                //This will only add the verses word if it is not already in the list.
                _words.Add(k);
            }
        }
    }

    public void HideWords()
    {
        if (_words.Count > 0) 
        {
        Random random = new Random();
        //Used to randomly select words to remove. Took me a second to make it adaptable
        int randomIndex = random.Next(0, _words.Count);
        string changeWord = _words[randomIndex];
        _hiddenWords.Add(changeWord);
        _words.Remove(changeWord);
        }
    }
    //A literal carbon copy that does the revese
    public void RevealWords()
    {
        if (_hiddenWords.Count > 0)
        {
            Random random = new Random();
            //Used to randomly select words to reveal.
            int randomIndex = random.Next(0, _hiddenWords.Count);
            string changeWord = _hiddenWords[randomIndex];
            _hiddenWords.Remove(changeWord);
            _words.Add(changeWord);
        }
    }

    //These simple get the list in case other parts of the program need to use them
    public List<string> GetWord()
    {
        return _words;
    }

    public List<string> GetHiddenWords()
    {
        return _hiddenWords;
    }

    public void DisplayWords()
    {
        //Runs through each string in the words list
        foreach (string k in _words)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine(_words[0]);
    }
}