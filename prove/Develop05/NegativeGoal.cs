public class NegativeGoal : Goal // This goal works like the negative eternal goal, where they lose points for bad habits. (The total point does not go below 0.)
{

    public NegativeGoal() : base() {}

    public NegativeGoal(string[] goalInfos) : base(goalInfos) 
    {
        _goalName = goalInfos[0];
        _goalDescription = goalInfos[1];
        _goalPoint = int.Parse(goalInfos[2]);
    }

    public NegativeGoal(string name,string description,int point)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoint = point * -1;
    }

    public override void CreateNewGoal()
    {
        Console.Write("What is the name of your goal?: ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points you lose when you failed?: ");
        _goalPoint = int.Parse(Console.ReadLine()) * -1;
    }

    public override string GetGoalDetail()
    {
        return $"[ ] {base.GetGoalDetail()}";
    }

    public override string FormatGoalLined()
    {
        return $"NegativeGoal::{base.FormatGoalLined()}";
    }
}