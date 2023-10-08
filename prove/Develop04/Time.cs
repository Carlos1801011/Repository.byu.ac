public class Activity
{
    private string _names;
    private string _descriptionNew;
    protected int _durationTime;
    public Activity(string name,string description,int duration)
    {
        _names = name;
        _descriptionNew = description;
        _durationTime = duration;
    }
    public Activity(int duration)
    {
        _durationTime = duration;
    }
    public Activity(){}
    public void DisplayBeginningMessage()
    {
        System.Console.WriteLine($"Welcome to the {_names} Activity!\nTry to follow everything to the letter");
        System.Console.WriteLine(_descriptionNew);
        System.Console.Write("How many seconds would you like this activity to last? > ");
        _durationTime = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Thank you. .");
        System.Console.WriteLine("Prepare yourself to begin. :) ");
        PauseWithSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        System.Console.WriteLine($"<<< Great job! You completed the {_names} Activity! See you Later >>>");
        PauseWithSpinner(3);
    }
    public void PauseWithSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {   
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
    public void Countdown(int seconds)
    {
        while(seconds> 0)
        {
        System.Console.Write($"{seconds}");
        Thread.Sleep(1000);
        System.Console.Write("\b \b");
        seconds--;
        }
    }
}