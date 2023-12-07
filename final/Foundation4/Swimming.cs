public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override string GetSummary()
    {
        return $"Swimming - {base.GetSummary()}, Laps: {laps}";
    }
}