using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.WriteLine("");

        //Defining Job 1
        Job job1 = new Job();
        job1._company = "Little Caesars Pizza";
        job1._jobTitle = "Crew Member";
        job1._startYear = 2021;
        job1._endYear = 2022;
        //Defining Job 2
        Job job2 = new Job();
        job2._company = "Green Summit";
        job2._jobTitle = "Crew";
        job2._startYear = 2022;
        job2._endYear = 2022;

        //Defining Resume number 1, in case of more future inputs
        Resume number1 = new Resume();
        number1._name = "Kaden Boam";
        number1._jobs.Add(job1);
        number1._jobs.Add(job2);

        /* Past tests, could be removed but left for future personal reference
        //First test of the program
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
        Console.WriteLine("");

        //Second test of the program
        job1.TheJob();
        job2.TheJob();
        Console.WriteLine("");

        //Third test of program
        Console.WriteLine(number1._jobs[0]._jobTitle);
        Console.WriteLine("");
        */

        //Forth test of program
        number1.ResumeDisplay();

    }
}