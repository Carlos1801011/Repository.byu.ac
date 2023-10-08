public  class BodyStretchActivity : Activity
{
    
    List<string> _bodyStretch = new List<string>();
    public BodyStretchActivity(): base("Body stretch", "In this activity you must stretch the parts of the body that appear on the screen and respect the time you indicated.", 60)
    {
        CompileParts();
    }
    private void CompileParts()
    
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        _bodyStretch.Add("chest");
        _bodyStretch.Add("lower back");
        _bodyStretch.Add("upper back");
        _bodyStretch.Add("fingers");
        _bodyStretch.Add("hands");
        _bodyStretch.Add("forearms");
        _bodyStretch.Add("shoulders");
        _bodyStretch.Add("neck");
    }
    public void RunActivity()
    {
        
        DisplayBeginningMessage();
        foreach (string part in _bodyStretch)
        {
            Console.Clear();
            System.Console.WriteLine($"Relax and stretch your {part}.");
            PauseWithSpinner(_durationTime/_bodyStretch.Count());
        }
        Console.Clear();
        DisplayEndingMessage();
    }

}