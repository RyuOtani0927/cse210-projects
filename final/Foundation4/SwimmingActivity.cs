public class SwimmingActivity : Activity
{
    private int _recordedLaps;
    public Activity(string date, double length, int laps) : base(date,length)
    {
        _activityType = "Swimming";
        _recordedLaps = laps;
    }
    public int GetRecordedLaps()
    {
        return _recordedLaps;
    }
    public void SetRecordedLaps(int laps)
    {
        _recordedLaps = laps;
    }

    public override double GetDistance()
    {
        return _recordedLaps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _activityLength) * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}