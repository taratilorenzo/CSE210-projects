using System;
using System.IO;
using System.IO.Enumeration;
using System.Text.Json;


public class Journal
{

    //variables
    public List<JournalEntry> _entries = new List<JournalEntry>();

    //write a new entry
    public void AddEntry(JournalEntry entry)
    {
        /*JournalEntry entry = new JournalEntry
        {
            _date = date,
            _prompt = prompt,
            _content = content
        };*/

        _entries.Add(entry);    
    }

    //display the journal
    public void DisplayAll()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        //Saving the file as Json
        /*Console.Write("Please enter the name of the file: "); string filename = Console.ReadLine();

        string jsonString = JsonSerializer.Serialize(_entry2);
        File.WriteAllText(filename+".json", jsonString);*/
        

        //save it as a txt
        using(StreamWriter outputFile = new StreamWriter(filename+".txt"))
        {
            foreach(JournalEntry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._content}");
            }
            
        }
    }

    //Load the Journal
    public void LoadFromFile(string filename)
    {
        //Journal should always be loaded before saving it.
        string[] lines = System.IO.File.ReadAllLines(filename+".txt");
        string date;
        string prompt;
        string content;

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            date = parts[0];
            prompt = parts[1];
            content = parts[2];

            JournalEntry entry = new JournalEntry
            {
                _date = date,
                _prompt = prompt,
                _content = content
            };
            _entries.Add(entry);
        }


        //load Jsonfile
        /*using(StreamReader reader = new StreamReader(filename+".json"))
        {
            string JsonFile = reader.ReadToEnd();
            _entry2 = JsonSerializer.Deserialize<List<JournalEntry>>(JsonFile);
        }*/
    }
}