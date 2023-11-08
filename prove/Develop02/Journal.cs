using System;
using System.IO;
using System.IO.Enumeration;
using System.Text.Json;
using Microsoft.VisualBasic;

public class Journal
{
    /*
    //variables
    string _filename = "Journal.txt";
    JournalEntry _journalEntries = new JournalEntry();
    List<string> _myJournal = new List<string>();

    //methods
    public string TimeOfTheDay()
    {
        DateTime currentTime = DateTime.Now;
        if(currentTime.Hour < 12)
        {
           return "Good Morning!";
        }
        else if(currentTime.Hour < 18)
        {
            return "Good Afternoon!";
        }
        else return "Good Evening!";
    } 

    public void Entry()
    {

        string prompt = _journalEntries.getPrompt();
        Console.WriteLine(prompt);
        _journalEntries.setDate();
        _myJournal.Add($"Date: {_journalEntries.getDate()} - Prompt: {prompt} \n {Console.ReadLine()}.\n");
    }

    public void Display()
    {
        foreach(string entryLine in _myJournal)
        {
            Console.WriteLine(entryLine);
        }
    }

    public void SaveEntriesTxt()
    {
        Console.Write("Please enter the file name you want to save this document? - "); _filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach(string entryLine in _myJournal)
            {
                outputFile.WriteLine(entryLine);
            }
        }
    }

    public void LoadJournal()
    {
        Console.Write("Please enter the file name you want to open/load? - "); _filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach(string line in lines)
        {
            _myJournal.Add(line);
        }
    }
    */

    //variables
    JournalEntry _entry = new JournalEntry();
    List<JournalEntry> _entry2 = new List<JournalEntry>();
    List<string> _entries = new List<string>();
    public Prompt _prompts = new Prompt();

    //methods
    public void RandomPrompt()
    {
        using(StreamReader reader = new StreamReader("Prompt.json"))
        {
            string PromptJsonFile = reader.ReadToEnd();
            _prompts = JsonSerializer.Deserialize<Prompt>(PromptJsonFile);
        }
        Random random = new Random();
        int randomNumber = random.Next(0,9);
        _entry.Prompt = _prompts.Prompts[randomNumber];
        Console.WriteLine(_entry.Prompt);

    }

    //write a new entry
    public void WriteContent()
    {
        RandomPrompt();
        _entry.Content = Console.ReadLine();
        //adding the date, prompt and content to my list entries
        string date = _entry.Date.ToShortDateString();
        _entries.Add($"Date: {date} - Prompt: {_entry.Prompt}\n{_entry.Content}"); 
        _entry2.Add(new JournalEntry {Date = _entry.Date, Prompt = _entry.Prompt, Content = _entry.Content});       
    }

    //display the journal
    public void DisplayJournal()
    {
        foreach(string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveFile()
    {
        //Saving the file as Json
        Console.Write("Please enter the name of the file: "); string filename = Console.ReadLine();

        string jsonString = JsonSerializer.Serialize(_entry2);
        File.WriteAllText(filename+".json", jsonString);
        

        //save it as a txt
        using(StreamWriter outputFile = new StreamWriter(filename+".txt"))
        {
            foreach(string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
            
        }
    }

    //Load the Journal
    public void LoadFile()
    {
        //Journal should always be loaded before saving it.
        Console.Write("Please enter the file name you want to open/load? - "); string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename+".txt");
        foreach(string line in lines)
        {
            _entries.Add(line);
        }

        //load Jsonfile
        using(StreamReader reader = new StreamReader(filename+".json"))
        {
            string JsonFile = reader.ReadToEnd();
            _entry2 = JsonSerializer.Deserialize<List<JournalEntry>>(JsonFile);
        }
    }
}