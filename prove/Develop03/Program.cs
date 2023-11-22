using System;

/*Description
Program Title: Scripture Memorizer

Description:
This scripture memorizer program is a C# console application that help user memorizing scriptures.
It hides words within the scriptures until all words are hidden.

Features:
1-User-friendly interface: The program is easily intuitive.
2-Result display: The scriptures will be hidden.

Technical Specifications:
-The program is implemented in C# using the .NET framework.
-The user interface is a console-based application.
-The program utilizes date structures such as arrays and list to store and manage data.
-The application follows object-oriented programming principles such as encapsulation and abstraction.
-The program contains proper code commenting and follow coding best practices for easy to read.

Functional Requirements:
1-Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
2-Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
3-Clear the console screen and display the complete scripture, including the reference and the text.
4-Prompt the user to press the enter key or type quit.
5-If the user types quit, the program should end.
6-If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture,
    clear the console screen, and display the scripture again.
7-The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
8-When all words in the scripture are hidden, the program should end.
9-When selecting the random words to hide, for the core requirements, you can select any word at random,
even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)

Design Requirements:
-Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
-Contain at least 3 classes in addition to the Program class: one for the scripture itself, one for the reference (for example "John 3:16"), and to represent a word in the scripture.
-Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6")

Submission:
-Develop the program using the principle of Encapsulation.
-Make sure to describe anything you have done to exceed the requirements in comments in the Program.cs file.
-Commit your source code and push it to GitHub.
-Verify that you can see your updated code at GitHub.
-In I-Learn, submit a link to your GitHub repository. In the submission comment, describe anything you have done to show creativity and exceed the core requirements.

Classes and Attributes:
 -Scripture: keeps track of both the reference and the text of the scripture. Can hide the words and get the rendered display of the text.
 -Reference: Keeps track of the book, chapter and verse information
 -Word: Keeps track of a single word and wether it is shown or hidden
*************************************************************************************************************************************************
| Class Scripture                        | Class Reference                                                            | Class Word              |
*************************************************************************************************************************************************
| HideRandomWords(numberToHide:int):void | GetDisplayText():string                                                    | Show():void             |
| GetDisplayText():string                | possible getters and setters                                               | Hide():void             |
| CheckIfHidden():bool                   |                                                                            | IsHidden():bool         |
|                                        |                                                                            | GetDisplayText():string |
*************************************************************************************************************************************************
| Scripture(ref:Reference, text:string)  | Reference(book:string, chapter:int, vers:int)                              | Word(text:string        |
|                                        | Reference(book:string, chapter:int, vers:int, startVerse:int,endVerse:int) |                         |
*************************************************************************************************************************************************
| _reference:Reference                   | _book:string                                                               | _word:string            |
| _words:List<Word>                      | _chapter:int                                                               | _isHidden:bool          | 
|                                        | _verse:int                                                                 |                         |
|                                        |_endVerse:int                                                               |                         |
*************************************************************************************************************************************************

*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

         Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world that He gave His only Begotten Son.", reference);

        scripture.HideWords();
    }
}