using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter your grade percentage (0-100):");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        if (numGrade >= 90)
        {
            if (numGrade >= 93)
            {
                Console.WriteLine("You received an A.");
            }
            else
            {
                Console.WriteLine("You received an A-.");
            }
        }
        else if (numGrade >= 80)
        {
            if (numGrade >= 87)
            {
                Console.WriteLine("You received a B+.");
            }
            else if (numGrade >= 83)
            {
                Console.WriteLine("You received a B.");
            }
            else
            {
                Console.WriteLine("You received a B-.");
            }
        }
        else if (numGrade >= 70)
        {
            if (numGrade >= 77)
            {
                Console.WriteLine("You received a C+.");
            }
            else if (numGrade >= 73)
            {
                Console.WriteLine("You received a C.");
            }
            else
            {
                Console.WriteLine("You received a C-.");
            }
        }
        else if (numGrade >= 60)
        {
            if (numGrade >= 67)
            {
                Console.WriteLine("You received a D+.");
            }
            else if (numGrade >= 63)
            {
                Console.WriteLine("You received a D.");
            }
            else
            {
                Console.WriteLine("You received a D-.");
            }
        }
        else if (numGrade >= 0)
        {
            Console.WriteLine("You received an F.");
        }
    }
}