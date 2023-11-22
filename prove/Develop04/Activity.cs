using System.Diagnostics;

public class Activity
{
    //Attributes
    private string _name;
    private string _description;
    private int _duration;

    //Constructors
    public Activity(){}
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Setters & Getters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    //Methods
    public void DisplayStartingMessage()
    {
        Console.Clear();
        //display the name of the activity
        Console.WriteLine($"Welcome to the {_name} Activity \n");
        //display the description of the activity
        Console.WriteLine($"{_description}\n");
        //display the duration 
        Console.Write("How long, in seconds, would you like for your sessions? "); 
        
        SetDuration(int.Parse(Console.ReadLine()));

        //pause
        Console.Clear();
        Console.Write("Get Ready"); ShowSpinner(3); Console.WriteLine("\n");
    }
    public void DisplayEndingMessage()
    {
        Console.Write("Well done!!"); ShowSpinner(3); Console.WriteLine("\n");
        Console.Write($"You have completed another {_duration} seconds of the {_name} Activity"); ShowSpinner(3);Console.WriteLine("\n");
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        //Initializing a list of character for my spinner using a List
        List<string> spinnerCharaters = new List<string>();
        spinnerCharaters.Add("|");
        spinnerCharaters.Add("/");
        spinnerCharaters.Add("-");
        spinnerCharaters.Add("\\");
        spinnerCharaters.Add("|");
        spinnerCharaters.Add("/");
        spinnerCharaters.Add("-");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string s = spinnerCharaters[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= spinnerCharaters.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for(int i=seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}