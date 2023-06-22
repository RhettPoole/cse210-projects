using System;
using System.Collections.Generic;

public class Menu
{
    private GoalTracker goalTracker;

    public Menu()
    {
        goalTracker = new GoalTracker();
    }

    public void DisplayMenu()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    goalTracker.ListGoals();
                    break;
                case 3:
                    goalTracker.SaveGoals();
                    break;
                case 4:
                    goalTracker.LoadGoals();
                    break;
                case 5:
                    goalTracker.RecordEvent();
                    break;
                case 6:
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("How many points do you want associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, points);
                break;
            case 2:
                goal = new EternalGoal(name, points);
                break;
            case 3:
                Console.Write("How many items are on the checklist? ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                goal = new ChecklistGoal(name, targetCount, points);
                break;
            default:
                Console.WriteLine("Invalid goal type. Creating a Simple Goal by default.");
                goal = new SimpleGoal(name, points);
                break;
        }

        goalTracker.AddGoal(goal);
        Console.WriteLine("New goal created successfully!");
    }
}
