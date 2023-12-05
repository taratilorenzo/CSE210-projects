using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class GoalManager : Goal
{
    //Attributes
    private List<Goal> _goals;
    private int _score; 

    //Constructor
    public GoalManager(string name, string description, int point):base(name, description,point)
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //Getters & Setters

    //Methods
    public void Start()
    {
        string filename = "";
        // display menu options
        Console.WriteLine("Welcome to the Eternal Quest program!");
        DisplayPlayerInfo();

        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. List the Goals");
            Console.WriteLine("4. Save progress");
            Console.WriteLine("5. Load progress");
            Console.WriteLine("6. Exit");
            // read user input
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    Console.WriteLine("What Goal would you like to accomplish? ");
                    ListGoalNames();
                    int choice = int.Parse(Console.ReadLine());
                    _score = _score + _goals[choice-1].RecordEvent();
                    break;

                case "3":
                    ListGoalDetails();
                    break;

                case "4":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    SaveGoals(filename);
                    break;
                    
                case "5":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    LoadGoals(filename);
                    break;    
                case "6":
                    Console.WriteLine("Thank you for using this app");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }

            DisplayPlayerInfo();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Current Score is: {_score}");
    }
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("Current goals:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetShortName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        int i = 1;

        foreach (Goal goal in _goals)
        {
            if(goal.IsComplete() == true)
            {
                Console.WriteLine($"{i}. [X] {goal.GetShortName()} ({goal.GetDescription()}).");
                i++;
            }
            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetShortName()} ({goal.GetDescription()}).");
                i++;
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("Write a short description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points associated with the goal: ");
        int points = int.Parse(Console.ReadLine());


        Goal newGoal;

        switch (type)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times should this goal be accomplished for a bonus: ");
                int target = int.Parse(Console.ReadLine());
                //Console.Write("Enter the bonus value if target hit: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                return;
        }
        _goals.Add(newGoal);
        //Console.WriteLine($"Goal '{name}' created successfully.");
    }
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {

            writer.Write($"{_score} \n");

            foreach (Goal goal in _goals)
            {
                writer.Write($"{goal.GetType().ToString()}:\n");
                writer.Write($"{goal.GetShortName()}\n");
                writer.Write($"{goal.GetDescription()}\n");
                writer.Write($"{goal.GetPoints()}\n");
                if (goal is EternalGoal)
                {
                    writer.Write(((EternalGoal)goal));
                }
                else if (goal is ChecklistGoal)
                {
                    writer.Write($"{((ChecklistGoal)goal).GetTarget()}\n");
                    writer.Write($"{((ChecklistGoal)goal).GetBonuses()}\n");
                }
                writer.WriteLine();
            }
        }
        //Console.WriteLine("Goals and score saved successfully.");
    }
    public void LoadGoals(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            _score = reader.Read();

            while (!reader.EndOfStream)
            {
                string type = reader.ReadLine();
                string name = reader.ReadLine();
                string description = reader.ReadLine();
                int point = reader.Read();
                Goal goal;

                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(name, description, point);
                        break;

                    case "EternalGoal":
                        bool isCompleted = bool.Parse(reader.ReadLine());
                        goal = new EternalGoal(name, description, point);
                        break;

                    case "ChecklistGoal":
                        int target = int.Parse(reader.ReadLine());
                        int bonus = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(name, description, point, target, bonus);
                        break;

                    default:
                        Console.WriteLine("Invalid goal type found in file. Skipping.");
                        continue;
                }

                _goals.Add(goal);
            }
        }
        //Console.WriteLine("Goals and score loaded successfully.");
    }

    public override int RecordEvent()
    {
        return 0;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}