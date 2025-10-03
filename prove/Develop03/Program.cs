using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture _list1 = new Scripture();
        Reference scripture1 = new Reference("2 Nephi", 2, 3, 5, "And it cam to pass that this test should work");
        _list1._scripture.Add(scripture1);

        _list1.DisplayScripture();
    }
}