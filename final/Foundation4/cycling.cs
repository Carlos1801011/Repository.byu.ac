class CyclingActivity : Activity
{
    private float _speed;
    public CyclingActivity(float speed, string date, int length):base(date,length,"Cycling")
    {
        _speed = speed;
    }
        public override float GetPac()
    {
        return 60/_speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetRange()
    {
        return _speed/60*GetLength();
    }
}