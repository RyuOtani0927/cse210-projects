public class SimpleGoal : Goal
{
    protected bool _ifCompleted;

    public SimpleGoal() : base()
    {
        _ifCompleted = false;
    }

    public SimpleGoal(string name, string description, int point) : base(name,description,point)
    {
        _ifCompleted = false;
    }
    public bool GetIfCompleted()
    {
        return _ifCompleted;
    }
    public void SetIfCompleted(bool ifCompleted)
    {
        _ifCompleted = ifCompleted;
    }
    
    public override string GetGoalDetail()
    {
        string checkComplete = "";
        if (_ifCompleted)
        {
            checkComplete = "X";
        }
        else
        {
            checkComplete = " ";
        }

        return $"[{checkComplete}] {base.GetGoalDetail()}";
    }

}