public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    public bool GetLivesInUSAF()
    {
        if( _country.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
    }
    
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetFormattedLocation()
    {
        string formattedAddress = $"   {_streetAddress}\n   {_city}\n   {_stateOrProvince}\n   {_country}";
        return formattedAddress;
    }
}