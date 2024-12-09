public class LectureEvent : Event
{
    private string _speakerName;
    private int _eventCapacity;
    public LectureEvent(string title, string description, string date, string time, string name, int capacity):base(title,description,date,time)
    {
        _eventType = "Lecture";
        _speakerName = name;
        _eventCapacity = capacity;
    }
    public LectureEvent(string title, string description, string date, string time, Address address, string name, int capacity):base(title,description,date,time,address)
    {
        _eventType = "Lecture";
        _speakerName = name;
        _eventCapacity = capacity;
    }
    public LectureEvent(string title, string description, string date, string time, string street, string city, string state, string country, string name, int capacity):base(title,description,date,time,street,city,state,country)
    {
        _eventType = "Lecture";
        _speakerName = name;
        _eventCapacity = capacity;
    }
    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public void SetSpeakerName(string name)
    {
        _speakerName = name;
    }
    public int GetEventCapacity()
    {
        return _eventCapacity;
    }
    public void SetEventCapacity(int capacity)
    {
        _eventCapacity = capacity;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()} \nSpeaker Name: {_speakerName} \nEvent Capacity: {_eventCapacity}";
    }
}
