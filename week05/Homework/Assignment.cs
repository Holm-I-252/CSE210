using System;

class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public (string, string) GetSummary()
    {
        return (_studentName, _topic);
    }
}