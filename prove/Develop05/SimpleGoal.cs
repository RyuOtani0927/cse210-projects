public class SimpleGoal : Goal
{
    private bool _ifCompleted;

    public SimpleGoal() : base()
    {
        _ifCompleted = false;
    }

    public SimpleGoal(string[] goalinfos) : base(goalinfos)
    {
        if (goalinfos[3] == "False")
        {
            _ifCompleted = false;
        }
        else
        {
            _ifCompleted = true;
        }
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

    public override string FormatGoalLined()
    {
        return $"SimpleGoal::{base.FormatGoalLined()}|{_ifCompleted}";
    }

    public override int RecordAccomplishment()
    {
        _ifCompleted = true;
        return _goalPoint;
    }
}