using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        List<string> fixedWords = new List<string>();

        string text = "hello my name is jeremy.";
        string[] words = text.Split(" ");
        Console.WriteLine(words[4]);
        fixedWords.Add(words[0]);
        Console.WriteLine(fixedWords[0]);
        fixedWords.Add(words[3]);
        Console.WriteLine(fixedWords[1]);
    }
}