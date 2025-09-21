using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int userGuess = 0;
            int guesses = 0;
            do
            {
                Console.Write("Between 1-100, what number am I thinking of? ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess < number) { Console.WriteLine("No, try higher!"); }
                else if (userGuess > number) { Console.WriteLine("No, try lower!"); }
                else if (userGuess == number) { Console.WriteLine("Correct!"); }
                Console.WriteLine("");
                guesses += 1;

            } while (userGuess != number);

            Console.WriteLine($"You got it in {guesses} guesses!");

            Console.WriteLine("Do you want to play again? y/n");
            again = Console.ReadLine();

        } while (again == "y");
    }
}