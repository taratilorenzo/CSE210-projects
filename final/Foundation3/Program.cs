using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Lecture lecture = new Lecture("Lecture", "LeaderShip Training", "Being a better Leader","John Maxwell", 100);
        Reception reception = new Reception("Reception", "RSVP to event coming up", "Leadership Training Coming Up");
        Outdoor outdoor = new Outdoor("Outdoor", "Better Leaders", "Gathering with Leader around the Globe", "Sunny");
    
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(lecture.FullDetails());

        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine(reception.SendEmail());

        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine(outdoor.WeatherForecast());
    
    
    
    }
}