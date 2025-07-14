using System;

class Comment
{
    private string _user;
    private string _content;

    public Comment(string user, string content)
    {
        _user = user;
        _content = content;
    }

    public (string, string) GetCommentInfo()
    {
        return (_user, _content);
    }
}