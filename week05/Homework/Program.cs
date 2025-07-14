using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment mathAssignment = new MathAssignment("John Doe", "Calculus", "Section 5.2", "Problems 1-10");
        var summary = mathAssignment.GetMathSummary();
        Console.WriteLine($"Student Name: {summary.Item1}, Topic: {summary.Item2}, Textbook Section: {summary.Item3}, Problems: {summary.Item4}");

        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "Literature", "The Great Gatsby");
        var writingSummary = writingAssignment.GetWritingSummary();
        Console.WriteLine($"Student Name: {writingSummary.Item1}, Topic: {writingSummary.Item2}, Title: {writingSummary.Item3}");
    }
}