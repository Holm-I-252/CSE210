using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();
        User user = new User(userName);
        bool running = true;
        while (running)
        {

            Console.WriteLine("Welcome to Eternal Quest! Choose from the options below:\n");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Complete a goal");
            Console.WriteLine("3. View all goals");
            Console.WriteLine("4. See total points");
            Console.WriteLine("5. Exit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Creating a new goal...");
                    Console.Write("Enter goal title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("Enter goal type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nChoose an option: ");
                    string goalType = Console.ReadLine();
                    if (goalType == "1")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                        user.AddGoal(simpleGoal);
                    }
                    else if (goalType == "2")
                    {
                        EternalGoal eternalGoal = new EternalGoal(title, description, points);
                        user.AddGoal(eternalGoal);
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter the number of tasks for the checklist goal: ");
                        int numberOfTasks = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many points should be awarded each time you complete a step?");
                        int singleCompletionPoints = int.Parse(Console.ReadLine());
                        ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, numberOfTasks, singleCompletionPoints);
                        user.AddGoal(checklistGoal);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type selected.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Completing a goal...");
                    Console.Write("Enter the title of the goal to complete: ");
                    string goalTitle = Console.ReadLine();
                    Goal selectedGoal = user.GetGoals().FirstOrDefault(g => g.GetTitle().Equals(goalTitle, StringComparison.OrdinalIgnoreCase));
                    if (selectedGoal != null)
                    {
                        selectedGoal.CompleteGoal(user);
                    }
                    else
                    {
                        Console.WriteLine("Goal not found.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Viewing all goals:");
                    List<Goal> goals = user.GetGoals();
                    foreach (Goal goal in goals)
                    {
                        goal.DisplayGoal();
                    }
                    break;
                case "4":
                    Console.WriteLine($"Total points: {user.GetTotalPoints()}");
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}