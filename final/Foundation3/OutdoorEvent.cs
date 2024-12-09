public class OutdoorEvent : Event
{
    private string _weatherForecast;
    public OutdoorEvent(string title, string description, string date, string time,string weather):base(title,description,date,time)
    {
        _eventType = "Outdoor";
        _weatherForecast = weather;
    }
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather):base(title,description,date,time,address)
    {
        _eventType = "Outdoor";
        _weatherForecast = weather;
    }
    public OutdoorEvent(string title, string description, string date, string time, string street, string city, string state, string country, string weather):base(title,description,date,time,street,city,state,country)
    {
        _eventType = "Outdoor";
        _weatherForecast = weather;
    }
    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }
    public void SetWeatherForecast(string weather)
    {
        _weatherForecast = weather;
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()} \nWeather Forecast: {_weatherForecast}";
    }
}