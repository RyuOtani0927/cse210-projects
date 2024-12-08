public class Address
{
    private string _streetName;
    private string _cityName;
    private string _stateName;
    private string _countryName;

    public Address()
    {
        _streetName = "";
        _cityName = "";
        _stateName = "";
        _countryName = "";
    }

    public Address(string street, string city, string state, string country)
    {
        _streetName = street;
        _cityName = city;
        _stateName = state;
        _countryName = country;
    }
    public string GetStreetName()
    {
        return _streetName;
    }
    public void SetStreetName(string street)
    {
        _streetName = street;
    }
    public string GetCityName()
    {
        return _cityName;
    }    public void SetCityName(string city)
    {
        _cityName = city;
    }
    public string GetStateName()
    {
        return _stateName;
    }
    public void SetStateName(string state)
    {
        _stateName = state;
    }
    public string GetCountryName()
    {
        return _countryName;
    }
    public void SetCountryName(string country)
    {
        _countryName = country;
    }

    public bool GetIfUSA()
    {
        if (_countryName == "USA" || _countryName == "US" || _countryName == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetFullAddress()
    {
        return $"{_streetName}, {_cityName}, {_stateName}, {_countryName}";
    }

}