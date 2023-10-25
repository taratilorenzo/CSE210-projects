using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //create my integer list
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when done.");

        do
        {
            Console.Write("Enter number to add in your list: "); number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }while(number != 0);

        //sum
        Console.WriteLine($"the sum is: {numbers.Sum()}");

        //average
        Console.WriteLine($"The average is : {numbers.Sum() / numbers.Count}");

        //Largest number
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}