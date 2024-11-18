public class Goal
{
    protected string _goalName;

    protected string _goalDescription;

    protected int _goalPoint;

    public Goal()
    {
        _goalName = "";
        _goalDescription = "";
        _goalPoint = 0;
    }

    public Goal(string name, string description, int point)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoint = point;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string name)
    {
        _goalName = name;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalDescription(string description)
    {
        _goalDescription = description;
    }
    public int GetGoalPoint()
    {
        return _goalPoint;
    }
    public void SetGoalPoint(int point)
    {
        _goalPoint = point;
    }

    public virtual void CreateNewGoal()
    {
        Console.Write("What is the name of your goal?: ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        _goalPoint = int.Parse(Console.ReadLine());

    }

    public virtual string GetGoalDetail()
    {
        return $"{_goalName} ({_goalDescription})";
    }

    


}