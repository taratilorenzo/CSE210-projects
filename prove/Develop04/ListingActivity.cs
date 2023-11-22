using System.Security.Cryptography;

public class ListingActivity : Activity
{
    //Attributes
    private int _count = 0;
    private List<string> _prompts;

    //constructors
    public ListingActivity(string name, string description) : base(name,description)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public ListingActivity(string name, string description, int duration) : base(name,description,duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    //Setters & Getters

    //Methods
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,_prompts.Count);
        Console.WriteLine($"--- {_prompts[randomNumber]}---");
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string userInput = Console.ReadLine();
        userList.Add(userInput);
        _count++;

        return userList;
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt.");
        GetRandomPrompt();
        Console.WriteLine("You may begin:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while(DateTime.Now < endTime)
        {
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();


    }

}