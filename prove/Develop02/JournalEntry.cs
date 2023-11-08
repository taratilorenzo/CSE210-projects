using System;

public class JournalEntry
{
    //variables
    public string _date {get;set;}
    public string _prompt {get; set;}
    public string _content {get; set;}


    //methods
    public void Display()
    {
        Console.WriteLine($"Date: {_date} | Prompt: {_prompt}\n{_content}");
    }

}

