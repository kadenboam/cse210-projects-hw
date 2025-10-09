using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        //To keep it spaced and neat
        Console.WriteLine("");

        //Simple test of Assignment class
        Assignment a1 = new Assignment("Henry Beckett", "Physics");
        Console.WriteLine(a1.GetSummary());

        //To keep it spaced and neat again
        Console.WriteLine("");

        //Simple test ot the MathAssignment class
        MathAssignment m1 = new MathAssignment("Alma Christchain", "Calculus", "Section 1.5", "Problem 25.a");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        //To keep it spaced and neat for last
        Console.WriteLine("");

        //Third and final test, WritingAssignments class test
        WritingAssignment w1 = new WritingAssignment("Henry Cooth", "ENG 150", "The Change Essay");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritinginformation());
    }
}