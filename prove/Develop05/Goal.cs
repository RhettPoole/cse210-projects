using System;

public class Goal
{
    public string Name { get; private set; }
    public bool IsGoalCompleted { get; protected set; }
    public int Value { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        IsGoalCompleted = false;
        Value = 0;
    }

    public void MarkComplete()
    {
        IsGoalCompleted = true;
    }

    public virtual int CalculateValue()
    {
        return Value;
    }

    public void DisplayStatus()
    {
        string status = IsGoalCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name}");
    }
}
