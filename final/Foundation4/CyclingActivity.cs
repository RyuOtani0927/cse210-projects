public class CyclingActivity : Activity
{
    private double _recordedSpeed;
    public CyclingActivity(string date, double length, double speed) : base(date,length)
    {
        _activityType = "Cycling";
        _recordedSpeed = speed;
    }
    public double GetRecordedSpeed()
    {
        return _recordedSpeed;
    }
    public void SetRecordedSpeed(double speed)
    {
        _recordedSpeed = speed;
    }
    
    public override double GetDistance()
    {
        return _activityLength / GetPace();
    }
    public override double GetSpeed()
    {
        return _recordedSpeed;
    }
    public override double GetPace()
    {
        return 60 / _recordedSpeed;
    }
}