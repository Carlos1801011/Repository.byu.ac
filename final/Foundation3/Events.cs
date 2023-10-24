class Event
{
    private string _type;
    private string _titleEvent;
    private string _dateTime;
    private string _timeZone;
    private string _description;
    private Address _address;
    public Event(string title, string desc, string date, string time, Address AdressInLecture, string type)
    {
        _titleEvent = title;
        _dateTime = date;
        _timeZone = time;
        _description = desc;
        _address = AdressInLecture;
        _type = type;
    }

        public void ShortMessage()
    {
        System.Console.WriteLine(_type);
        System.Console.WriteLine(_titleEvent);
        System.Console.WriteLine(_dateTime);
    }

    public string GetTitle()
    {
        return _titleEvent;
    }
    public string GetDate()
    {
        return _dateTime;
    }
    public string GetTime()
    {
        return _timeZone;
    }
    public string GetDescription()
    {
        return _description;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void StandardMessage()
    {
        System.Console.WriteLine(_titleEvent);
        System.Console.WriteLine(_description);
        System.Console.WriteLine(_dateTime + " " + _timeZone);
        System.Console.WriteLine(_address.FullAddress());
    }
}