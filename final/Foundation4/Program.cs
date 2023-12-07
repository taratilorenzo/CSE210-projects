using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Activity running = new Running(DateTime.Now, 30, 5.0);
        Activity bicycle = new Bicycle(DateTime.Now, 60, 20.0);
        Activity swimming = new Swimming(DateTime.Now, 45, 20);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(bicycle.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}