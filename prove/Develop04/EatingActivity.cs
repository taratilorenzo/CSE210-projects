public class EatingActivity : Activity
{
    //Attributes
    private List<string> _fruits;
    private List<string> _awareness;
    
    //Constructor
    public EatingActivity(string name, string description) : base(name,description)
    {
        _fruits = new List<string>
        {
            "Grapes", "Pineapple", "Watermelon", "Mango", "Apple", "Orange", "Kiwi"
        };
        _awareness = new List<string>
        {
            "Pay close attention on the taste.", "How is the texture?", "What sensations you are getting as you chew and swallow?"
        };
    }
    
    //Setters & Getters

    //Methods
    public string GetRandomFruit()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _fruits.Count);
        return _fruits[randomNumber];
    }

    public void DisplayFruit()
    {
        Console.WriteLine($"---{GetRandomFruit()}---");
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following fruit:");
        DisplayFruit();
        Console.WriteLine("Imagine eating the fruit!!");
        Console.Write("Press Enter when ready"); Console.ReadLine();

         Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin: "); ShowCountDown(5); Console.WriteLine("\n");

        foreach(string question in _awareness)
        {
            Console.WriteLine(question); ShowSpinner(7);
        }

        DisplayEndingMessage();
    }

}