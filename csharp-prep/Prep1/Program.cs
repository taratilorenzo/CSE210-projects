using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        //Prompt the user's Last name
        Console.Write("Please type your last name? ");
        string last_name = Console.ReadLine();

        //Prompt the user's first name
        Console.Write("Please type your first name? ");
        string first_name = Console.ReadLine();

        //Print the output
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}