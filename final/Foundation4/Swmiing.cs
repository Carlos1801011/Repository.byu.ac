class SwimmingActivity:Activity
{
    private int _numberOfLaps;
    public SwimmingActivity(int laps, string date, int length): base(date,length,"Swimming")
    {
        _numberOfLaps = laps;
    }
    public override float GetRange()
    {
        return _numberOfLaps*50f/1000f;
    }
    public override float GetSpeed()
    {
        return GetRange()/GetLength()*60;
    }
    public override float GetPac()
    {
        return GetLength()/GetRange();
    }
}