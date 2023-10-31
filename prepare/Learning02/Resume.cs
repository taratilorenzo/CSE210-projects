//create the class resume
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //methods
    public void Display()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}