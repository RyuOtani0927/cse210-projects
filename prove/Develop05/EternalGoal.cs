public class EternalGoal : Goal
{

    public EternalGoal() : base() {}

    public EternalGoal(string name,string description,int point) : base(name, description, point)
    {
    }

    public override string GetGoalDetail()
    {
        return $"[ ] {base.GetGoalDetail()}";
    }
}