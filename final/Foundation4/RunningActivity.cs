public class RunningActivity : Activity
{
    private double _recordedDistance;
    public RunningActivity(string date, double length, double distance):base(date,length)
    {
        _activityType = "Running";
        _recordedDistance = distance;
    }
    public double GetRecordedDistance()
    {
        return _recordedDistance;
    }
    public void SetRecordedDistance(double distance)
    {
        _recordedDistance = distance;
    }
    public override double GetDistance()
    {
        return _recordedDistance;
    }
    public override double GetSpeed()
    {
        return (_recordedDistance / _activityLength) * 60;
    }
    public override double GetPace()
    {
        return _activityLength / _recordedDistance;
    }
}