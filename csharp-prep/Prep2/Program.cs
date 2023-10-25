using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //using the variable letter to distinguish the grade
        string letter;

        //Ask the user for their grade percentage
        Console.Write("Please enter your grade percentage? "); 
        string percentageString = Console.ReadLine();

        //converting the string percentage into an integer
        int percentageInteger = int.Parse(percentageString);

        //Assigning the percentage to letters using if-else if-else statements
        if (percentageInteger >= 90 && percentageInteger <= 100)
        {
            //Console.WriteLine("your grade is A");
            letter = "A";
        }
        else if (percentageInteger >= 80 && percentageInteger < 90)
        {
            //Console.WriteLine("your grade is B");
            letter = "B";
        }
        else if (percentageInteger >= 70 && percentageInteger < 80)
        {
            //Console.WriteLine("your grade is C");
            letter = "C";
        }
        else if (percentageInteger >= 60 && percentageInteger < 70)
        {
            //Console.WriteLine("your grade is D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("Your grade is F");
            letter = "F";
        }

        //output based on the grade
        Console.WriteLine($"your grade is {letter}");

        //Assuming that passing is AT LEAST 70%. Display if the user pass
        if(percentageInteger >= 70)
        {
            Console.WriteLine("Congratulation, You Pass!");
        }
        else
        {
            Console.WriteLine("You are not quite there yet! Keep studying with diligence and you will attract success!");
        }

    }
}