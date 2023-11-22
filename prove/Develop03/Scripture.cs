using System;
using System.Collections.Generic;

class Scripture
{
    private string _text;
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] wordStrings = _text.Split(' ');
        _words = new List<Word>();

        foreach (string wordString in wordStrings)
        {
            _words.Add(new Word(wordString));
        }
    }

    public void Display()
    {
        Console.WriteLine("Scripture: " + GetHiddenText());
        Console.WriteLine("Reference: " + _reference);
    }

    public void HideWords()
    {
        Console.WriteLine("Press Enter to hide words, or 'Q' to quit.");
        Display();

        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                DisplayHiddenText();
            }
            else if (keyInfo.Key == ConsoleKey.Q)
            {
                Console.WriteLine("\nQuitting...");
                return;
            }
        } while (true);
    }

    private string GetHiddenText()
    {
        string hiddenText = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenText += new string('_', word._text.Length) + " ";
            }
            else
            {
                hiddenText += word._text + " ";
            }
        }
        return hiddenText.Trim();
    }

    private void DisplayHiddenText()
    {
        Console.WriteLine("Scripture: " + GetHiddenText());
        Console.WriteLine("Reference: " + _reference);
    }
}