using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResults(userName, squareNumber);

        
        //DisplayWelcome function
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        //PromptUserName function
        static string PromptUserName(){
            Console.Write("Please write your Name: "); return Console.ReadLine();
        }

        //PromptUserNumber function
        static int PromptUserNumber(){
            Console.Write("Please write your favorite number: "); return int.Parse(Console.ReadLine());
        }

        //SquareNumber function
        static int SquareNumber(int number){
            return number * number;
        }

        //DisplayResult function
        static void DisplayResults(string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}