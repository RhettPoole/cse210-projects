using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override int CalculateValue()
    {
        return Value;
    }
}