abstract class  Activity
{
    private string _date;
    private int _length;
    private string _type;
    public Activity(string date, int length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }
    public string GetAll()
    {
        return $"{_date} {_type} ({_length})- Distance {GetRange()} km, Speed {GetSpeed()} kph, Pace {GetPac()} min per km\n";
    }



    public abstract float GetRange();
    public abstract float GetSpeed();
    public abstract float GetPac();

    public int GetLength()
    {
        return _length;
    }
}