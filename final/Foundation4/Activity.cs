public class Activity
{
    protected string _activityDate;
    protected double _activityLength;
    protected string _activityType;
    public Activity(string date, double length)
    {
        _activityDate = date;
        _activityLength = length;
        _activityType = "";
    }
    public string GetActivityDate()
    {
        return _activityDate;
    }
    public void SetActivityDate(string date)
    {
        _activityDate = date;
    }
    public double GetActivityLength()
    {
        return _activityLength;
    }
    public void SetActivityLength(double length)
    {
        _activityLength = length;
    }
    public string GetActivityType()
    {
        return _activityType;
    }
    public void SetActivityType(string type)
    {
        _activityType = type;
    }


    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_activityDate} {_activityType} ({_activityLength} min): Distance {String.Format("{0:0.0#}",GetDistance())} miles, Speed {String.Format("{0:0.0#}",GetSpeed())} mph, Pace: {String.Format("{0:0.0#}",GetPace())} min per mile";
    }
}