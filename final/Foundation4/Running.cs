public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override string GetSummary()
    {
        return $"Running - {base.GetSummary()}, Distance: {distance} km";
    }
}