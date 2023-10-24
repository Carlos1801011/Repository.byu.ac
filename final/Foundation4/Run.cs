class RunningActivity : Activity
{
    private float _distanceOfRun;
    public RunningActivity(float distance2, string date, int length): base(date,length,"Controlated Running")
    {
        _distanceOfRun = distance2;
    }
    public override float GetRange()
    {
        return _distanceOfRun;
    }
    public override float GetPac()
    {
        return GetLength()/_distanceOfRun;
    }
    public override float GetSpeed()
    {
        return _distanceOfRun/GetLength() * 60;
    }

}