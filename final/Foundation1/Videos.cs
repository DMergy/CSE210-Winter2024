using System;

public class Videos
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comments> _comments = new List<Comments>();

    public Videos(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void ListComments(Comments comments)
    {
        _comments.Add(comments);
    }

    public int CountComments()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comments comments in _comments)
        {
            comments.DisplayInfo();
        }

    }

}