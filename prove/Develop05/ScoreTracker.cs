using System;
using System.Collections.Generic;

public class ScoreTracker
{
    private int totalScore;
    private List<Goal> goals;

    public ScoreTracker()
    {
        totalScore = 0;
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in goals)
        {
            if (goal.Name == goalName)
            {
                totalScore += goal.CalculateValue();

                if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.MarkCompleted();
                    Console.WriteLine($"{checklistGoal.Name} marked as completed.");
                }

                break;
            }
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            string completionStatus = goal.IsGoalCompleted ? "[X]" : "[ ]";
            Console.WriteLine($"{completionStatus} {goal.Name}");
            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"Completed {checklistGoal.CompletedCount}/{checklistGoal.TargetCount} times");
            }
        }
    }
}
