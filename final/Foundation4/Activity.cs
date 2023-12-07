public class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public virtual string GetSummary()
    {
        return $"Date: {date}, Duration: {duration} minutes";
    }
}