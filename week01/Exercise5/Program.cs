using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }
        int SquareNumber(int number)
        {
            return number * number;
        }
        void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Squared Number: " + squaredNumber);
        }
        void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }
        Main();
    }
}