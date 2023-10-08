class BreathingActivity : Activity
{
    public BreathingActivity():base("Breathing","  This activity will help you become less tense when inhaling and exhaling.When you do, clear your mind and concentrate. .",60)
    {
    }
    public BreathingActivity(int duration) : base("Breathing","This activity will help you become less tense when inhaling and exhaling.When you do, clear your mind and concentrate..",duration)
    {
    }
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {
    }
    private void BreatheIn(int time)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.Write("Breathe In...");
        Countdown(time);
    }
    private void BreatheOut(int time)
    {
        System.Console.Write("Breathe Out...");
        Countdown(time);
    }
    private void Hold(int time)
    {
        System.Console.Write("Hold...");
        Countdown(time);
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationTime);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Clear();
            BreatheIn(4);
            Console.Clear();
            Hold(4);
            Console.Clear();
            BreatheOut(4);
            Console.Clear();
            Hold(4);
            currentTime = DateTime.Now;
        }
        Console.Clear();
        DisplayEndingMessage();

    }
}