public class Bicycle : Activity
{
    private double speed;

    public Bicycle(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override string GetSummary()
    {
        return $"Bicycle - {base.GetSummary()}, Speed: {speed} km/h";
    }
}