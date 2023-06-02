using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Notice the syntax here that the MathAssignment has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
