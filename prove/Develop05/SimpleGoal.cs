using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override int CalculateValue()
    {
        if (IsGoalCompleted)
            return 0;
        else
            return Value;
    }
}