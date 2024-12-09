public class Event
{
    protected string _eventTitle;
    protected string _eventDescription;
    protected string _eventDate;
    protected string _eventTime;
    protected Address _eventAddress = new();
    protected string _eventType;

    public Event(string title, string description, string date, string time)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventType = "";
    }
    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = address;
        _eventType = "";
    }
    public Event(string title, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _eventAddress = new Address(street,city,state,country);
        _eventType = "";
    }
    
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public void SetEventTitle(string title)
    {
        _eventTitle = title;
    }
    public string GetEventDescription()
    {
        return _eventDescription;
    }
    public void SetEventDescription(string description)
    {
        _eventDescription = description;
    }
    public string GetEventDate()
    {
        return _eventDate;
    }
    public void SetEventDate(string date)
    {
        _eventDate = date;
    }
    public string GetEventTime()
    {
        return _eventTime;
    }
    public void SetEventTime(string time)
    {
        _eventTime = time;
    }

    public string GetEventType()
    {
        return _eventType;
    }    
    
    public void SetEventType(string type)
    {
        _eventType = type;
    }
    public void SetAddress(Address address)
    {
        _eventAddress = address;
    }
    public void SetAddress(string street, string city, string state, string country)
    {
        _eventAddress = new Address(street,city,state,country);
    }


    public string GetStandardDetails()
    {
        return $"Event Title: {_eventTitle} \nDescription: {_eventDescription} \nDate: {_eventDate} \nTime: {_eventTime} \nAddress: {_eventAddress.GetFullAddress()}";   
    }
    public virtual string GetFullDetails()
    {
        return $"Event Title: {_eventTitle} \nDescription: {_eventDescription} \nDate: {_eventDate} \nTime: {_eventTime} \nAddress: {_eventAddress.GetFullAddress()} \nEvent Type: {_eventType} Event"; 
    }
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType} Event \nTitle: {_eventTitle}\nDate: {_eventDate}";
    }
    public void DisplayMarketingMessage()
    {
        Console.WriteLine();
        Console.WriteLine(GetFullDetails());
        Console.WriteLine();
    }

}