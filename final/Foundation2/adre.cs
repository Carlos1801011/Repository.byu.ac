public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    //set the bool Usa name for the letters
    public bool GetLivesInUSAF()
    {
        if( _country.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
    }

    //set the adress and lication of the city or country if you need to change
    
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