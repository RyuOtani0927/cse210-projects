public class EternalGoal : Goal
{

    public EternalGoal() : base() {}

    public EternalGoal(string[] goalInfos) : base(goalInfos) {}

    public EternalGoal(string name,string description,int point) : base(name, description, point)
    {
    }

    public override string GetGoalDetail()
    {
        return $"[ ] {base.GetGoalDetail()}";
    }

    public override string FormatGoalLined()
    {
        return $"EternalGoal:{base.FormatGoalLined()}";
    }
}