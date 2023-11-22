using Microsoft.Win32.SafeHandles;

public class BreathingActivity : Activity
{
    //Attributes

    //Constructors
    public BreathingActivity(string name, string description) : base(name,description)
    {

    }
    public BreathingActivity(string name, string description, int duration) : base(name,description,duration)
    {

    }

    //Setters & Getters

    //Methods
    public void Run()
    {
        //display message
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while(DateTime.Now < endTime)
        {
            Console.Write($"Breath In..");
            for(int i = 5; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();

            Console.Write($"Breath Out..");
            for(int i = 6; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("\n");
        } 

        //display end message
        DisplayEndingMessage();       
    }
}