using System;
using System.Text.Json;

public class Prompt
{
    //variables
    //public List<string> _prompts {get; set;}
    public List<string> _prompts = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are 3 things I am grateful for?",
        "Have I been kind today?",
        "Have I thought about writing a statement of success for myself?",
        "Did I think to pray?",
        "What is tomorrow's plan?"
    };
    //methods
    /*
    //using Prompt.json
    public string GetRandomPrompt()
    {
        using(StreamReader reader = new StreamReader("Prompt.json"))
        {
            string PromptJsonFile = reader.ReadToEnd();
            Console.WriteLine(PromptJsonFile);
            _prompts = JsonSerializer.Deserialize<List<string>>(PromptJsonFile);
        }
        Random random = new Random();
        int randomNumber = random.Next(0,9);
        return _prompts[randomNumber];
    }
    */

    //using a predetermined list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0,9);
        return _prompts[randomNumber];
    }


}
