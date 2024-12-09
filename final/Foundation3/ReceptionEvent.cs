public class ReceptionEvent : Event
{
    private string _receptionEmail;
    public ReceptionEvent(string title, string description, string date, string time, string email):base(title,description,date,time)
    {
        _eventType = "Recepetion";
        _receptionEmail = email;
    }
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email):base(title,description,date,time,address)
    {
        _eventType = "Recepetion";
        _receptionEmail = email;
    }
    public ReceptionEvent(string title, string description, string date, string time, string street, string city, string state, string country, string email):base(title,description,date,time,street,city,state,country)
    {
        _eventType = "Recepetion";
        _receptionEmail = email;
    }
    public string GetReceptionEmail()
    {
        return _receptionEmail;
    }
    public void SetReceptionEmail(string email)
    {
        _receptionEmail = email;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()} \nEmail: {_receptionEmail}";
    }

}