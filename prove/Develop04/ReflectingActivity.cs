public class ReflectingActivity : Activity
{
    //Attributes
    private List<string> _prompts;
    private List<string> _questions;

    //constructors
    public ReflectingActivity(string name, string description) : base(name,description)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //Setters & Getters

    //Methods
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _questions.Count);
        return _questions[randomNumber];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin");



        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while(DateTime.Now < endTime)
        {
            DisplayQuestion();
            //Thread.Sleep(5000);
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        
    }

}