using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, and type 0 when finished! ");
        int userInput;
        List<int> numbers = new List<int>();
        int sum = 0;
        double avg = 0;
        int lNumber = 0;
        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            numbers.Add(userInput);
        } while (userInput != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > lNumber) { lNumber = numbers[i]; }
        }
        Console.WriteLine(numbers.Count);
        Console.WriteLine(sum);
        avg = (double)sum / (numbers.Count - 1);
        Console.WriteLine($"The Sum of those numbers is: {sum}!");
        Console.WriteLine($"The Average of those numbers is: {avg}!");
        Console.WriteLine($"The Largest number in the list is: {lNumber}");
    }
}