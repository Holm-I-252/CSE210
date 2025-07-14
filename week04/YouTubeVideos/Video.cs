using System;

class Video
{
    private string _title;
    private string _uploader;
    private int _length; // in seconds

    private Comment[] _comments;

    public Video(string title, string uploader, int length, Comment[] comments)
    {
        _title = title;
        _uploader = uploader;
        _length = length;
        _comments = comments;
    }

    public Video(string title, string uploader, int length)
    {
        _title = title;
        _uploader = uploader;
        _length = length;
    }

    public (string, string, int, Comment[]) GetVideoInfo()
    {
        return (_title, _uploader, _length, _comments);
    }

    public void AddComment(Comment comment)
    {
        if (_comments == null)
        {
            _comments = new Comment[] { comment };
        }
        else
        {
            Array.Resize(ref _comments, _comments.Length + 1);
            _comments[_comments.Length - 1] = comment;
        }
    }

}