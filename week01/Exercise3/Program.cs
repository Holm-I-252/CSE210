using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool running = true;
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        int guessedNumber = 0;
        int attempts = 0;
        while (running)
        {
            do
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                string input = Console.ReadLine();
                guessedNumber = int.Parse(input);
                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                    attempts++;
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                    attempts++;
                }
                else if (guessedNumber == randomNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number. It took you {attempts + 1} attempts.");
                }
            }
            while (guessedNumber != randomNumber);

            Console.WriteLine("Would you like to play again? (yes/no)");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "no")
            {
                running = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}