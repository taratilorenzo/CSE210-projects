using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Asking the user for a random number
        //Console.Write("Please pick a random number? "); int randomNumber = int.Parse(Console.ReadLine());
        Random generateRandomNumber = new Random();
        int magicNumber = generateRandomNumber.Next(1, 101);

        int guessNumber = -1;

        //if statement checking the if guess finds the random number.
        //
       while( magicNumber != guessNumber )
        {
             //Asking the user for a guess of what the number is
            Console.Write("Guess the magic random number? "); guessNumber = int.Parse(Console.ReadLine());

            

            if( magicNumber == guessNumber )
            {
                Console.WriteLine("Awesome! you found the Magic number!");
            }
            else if(magicNumber > guessNumber)
            {
                Console.WriteLine("Magic Number is Higher.");
            }
            else
            {
                Console.WriteLine("The Magic Number is Lower.");
            }
        }
    }
}