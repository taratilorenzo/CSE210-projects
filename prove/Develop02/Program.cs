using System;
using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;

/*Description
Program Title: Journal

Description:
This Journal program is a C# console application that invite the user to write his/journal
by prompting him/her with a start-reflective question.
He/She then write his/her thoughts then save it into a txt file and json file.

Features:
1-User-friendly interface: The program is easily intuitive.
2-Result display: The journal can be display in the console application.

Technical Specifications:
-The program is implemented in C# using the .NET framework.
-The user interface is a console-based application.
-The program utilizes date structures such as arrays and list to store and manage data.
-The application follows object-oriented programming principles such as encapsulation and abstraction.
-The program contains proper code commenting and follow coding best practices for easy to read.

Functional Requirements:
1-Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
2-Display the journal - Iterate through all entries in the journal and display them to the screen.
3-Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
4-Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file.
    This should replace any entries currently stored the journal.
5-Provide a menu that allows the user choose these options
6-Your list of prompts must contain at least five different prompts. 
    Make sure to add your own prompts to the list, but the following are examples to help get you started:
    -Who was the most interesting person I interacted with today?
    -What was the best part of my day?
    -How did I see the hand of the Lord in my life today?
    -What was the strongest emotion I felt today?
    -If I had one thing I could do over today, what would it be?
7-Your interface should generally follow the pattern shown in the video demo below.

Submission
-Develop the program using the principle of Abstraction as described above.
-Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
-Commit your source code and push it to GitHub.
-Verify that you can see your updated code at GitHub.
-In I-Learn, submit a link to your GitHub repository. In the submission comment, describe anything you have done to show creativity and exceed the core requirements.
*/

class Program
{
    static void Main(string[] args)
    {
        //variables
        Journal myJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");

        
        //choices using switch in a loop while
        while(true)
        {
            Console.WriteLine("1-Write.");
            Console.WriteLine("2-Display.");
            Console.WriteLine("3-Save.");
            Console.WriteLine("4-Load.");
            Console.WriteLine("5-Exit.");

            //user choice
            Console.Write("Please select one of the choices above:"); string choice = Console.ReadLine();

            //switch
            switch(choice)
            {
                case "1"://write
                    myJournal.WriteContent();
                    break;
                case "2"://display
                    myJournal.DisplayJournal();
                    break;
                case "3"://save
                    myJournal.SaveFile();
                    break;
                case "4"://load
                    myJournal.LoadFile();
                    break;
                case "5":
                    Environment.Exit(0);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please chose within the given options!");
                    break;
            }

        }

    }
}