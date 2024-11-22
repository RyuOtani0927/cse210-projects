public class ChecklistGoal : Goal
{
    private int _bonusPoint;
    private int _requiredProgress;
    private int _progress;

    public ChecklistGoal() : base()
    {
        _bonusPoint = 0;
        _requiredProgress = 0;
        _progress = 0;
    }

    public ChecklistGoal(string[] goalInfos) : base(goalInfos)
    {
        _bonusPoint = int.Parse(goalInfos[3]);
        _requiredProgress = int.Parse(goalInfos[4]);
        _progress = int.Parse(goalInfos[5]);
    }

    public ChecklistGoal(string name, string description, int point, int bonus, int required) : base(name, description, point)
    {
        _bonusPoint = bonus;
        _requiredProgress = required;
        _progress = 0;
    }
    
    public int GetBonusPoint()
    {
        return _bonusPoint;
    }
    public void SetBonusPoint(int bonus)
    {
        _bonusPoint = bonus;
    }
    public int GetRequiredProgress()
    {
        return _requiredProgress;
    }
    public void SetRequiredProgress(int required)
    {
        _requiredProgress = required;
    }
    public int GetProgress()
    {
        return _progress;
    }
    public void SetProgress(int progress)
    {
        _progress = progress;
    }

    public override void CreateNewGoal()
    {
        base.CreateNewGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
        _requiredProgress = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?: ");
        _bonusPoint = int.Parse(Console.ReadLine());
    }  

    public override string GetGoalDetail()
    {
        string checkComplete = "";
        if (_progress >= _requiredProgress)
        {
            checkComplete = "X";
        }
        else
        {
            checkComplete = " ";
        }

        return $"[{checkComplete}] {base.GetGoalDetail()} - Currently Completed: {_progress}/{_requiredProgress}";
    }

    public override string FormatGoalLined()
    {
        return $"ChecklistGoal::{base.FormatGoalLined()}|{_bonusPoint}|{_requiredProgress}|{_progress}";
    }

    public override int RecordAccomplishment()
    {
        _progress = _progress + 1;

        if (_progress == _requiredProgress)
        {
            return _goalPoint + _bonusPoint;
        }
        else
        {
            return _goalPoint;
        }
    }
}