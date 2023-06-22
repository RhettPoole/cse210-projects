using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CompletedCount { get; private set; }

    public ChecklistGoal(string name, int targetCount, int value) : base(name)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override int CalculateValue()
    {
        int baseValue = base.CalculateValue();
        if (CompletedCount == TargetCount)
        {
            return baseValue + 500; // Apply the bonus
        }
        return baseValue;
    }

    public void MarkCompleted()
    {
        CompletedCount++;
        if (CompletedCount >= TargetCount)
        {
            IsGoalCompleted = true;
        }
    }
}
