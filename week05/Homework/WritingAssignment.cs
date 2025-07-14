using System;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public (string, string, string) GetWritingSummary()
    {
        var baseSummary = GetSummary();
        return (baseSummary.Item1, baseSummary.Item2, _title);
    }
}