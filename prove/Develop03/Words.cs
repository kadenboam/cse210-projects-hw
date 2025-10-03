public class Words
{
    //Took me a second to figure out, after reviewing prep4 program under the prep file
    
    List<string> _words = new List<string>();
    List<string> _hiddenWords = new List<string>(); 
    
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
        //After researching better alternatives
        string[] array = Verse.Split(" ");
        foreach (string k in array)
        {
            _words.Add(k);
        }
    }

    public void DisplayWords()
    {
        foreach (string k in _words)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine(_words[0]);
    }
}