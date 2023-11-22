using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!\n");

        //Menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t 1. Start Breathing Activity");
        Console.WriteLine("\t 2. Start Reflecting Activity");
        Console.WriteLine("\t 3. Start Listing Activity");
        Console.WriteLine("\t 4. Quit ");
        Console.Write("Select a choice from the menu:"); 
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                break;
            case 2:
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
                break;
            case 3:
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
                break;
            case 4:
                break;
            default:
                break;
        }
    }
}