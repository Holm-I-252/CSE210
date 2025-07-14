using System;

class MathAssignment : Assignment
{
    protected string _textbookSection;
    protected string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public (string, string, string, string) GetMathSummary()
    {
        var baseSummary = GetSummary();
        return (baseSummary.Item1, baseSummary.Item2, _textbookSection, _problems);
    }

}