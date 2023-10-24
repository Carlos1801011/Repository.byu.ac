class OutdoorEvent : Event
{
    private string _weatherForday;
    public OutdoorEvent(string weather1, string title, string desc, string date, string time, Address AdressInLecture): base(title,desc,date,time,AdressInLecture,"Outdoor Event")
    {
        _weatherForday = weather1;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("Weather for this day: "+_weatherForday);
    }
}