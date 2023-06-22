using System;
using System.Collections.Generic;

public class GoalTracker
{
    private List<Goal> goals;

    public GoalTracker()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ListGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            Console.WriteLine("List of Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }
    }

    public void SaveGoals()
    {
        // Placeholder: Add logic to save goals to a file or database
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        // Placeholder: Add logic to load goals from a file or database
        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent()
    {
        // Placeholder: Add logic to record an event for a goal
        Console.WriteLine("Event recorded successfully.");
    }
}
