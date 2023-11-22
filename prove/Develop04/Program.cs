using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!\n");
        while (true)
        {
            //Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t 1. Start Breathing Activity");
            Console.WriteLine("\t 2. Start Reflecting Activity");
            Console.WriteLine("\t 3. Start Listing Activity");
            Console.WriteLine("\t 4. Start Eating Activity");
            Console.WriteLine("\t 5. Quit ");
            Console.Write("Select a choice from the menu:"); 
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                    break;
                case 4:
                    EatingActivity eatingActivity = new EatingActivity("Eating", "This activity will transport you into the beautiful nature and creation of God.");
                    eatingActivity.Run();
                    break;
                case 5:
                    System.Environment.Exit(1);
                    break;
                default:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}