using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Lorenzo Tarati","Chemistry");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Lorenzo Tarati","Mathematic","7.3","8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Lorenzo J Tarati","Monkeys around the world","The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}