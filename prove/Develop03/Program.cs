using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        //This is used to make a new list to keep track of all the scripture, in case we wanted more list (as in the BoM or the PoGP)
        Scripture _list1 = new Scripture();
        //Using the presets from the Reference file, we can manipulate the data that is private
        Reference _scripture1 = new Reference("2 Nephi", 2, 3, 5, "And it came to pass that this test should work");
        //Add that scripture to the list
        _list1._scripture.Add(_scripture1);

        //Now we just display the scripture. Randomize the sellection later in Scripture.cs
        _list1.DisplayScripture();
        string verse = _list1._scripture[0].GetVerse();
        
        Words _word1 = new Words(verse);
        _word1.DisplayWords();
    }
}