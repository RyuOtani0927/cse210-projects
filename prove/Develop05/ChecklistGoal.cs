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
}