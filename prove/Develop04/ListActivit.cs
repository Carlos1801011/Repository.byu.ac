public class ListingActivity:Activity
{
    List<string> _promptsHEre = new List<string>();
    List<string> _responsesNew = new List<string>();
    string _prompt;
    public ListingActivity():base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",60)
    {
        CompilePrompts();
    }
    public ListingActivity(int duration) : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",duration)
    {
        CompilePrompts();
    }
    public ListingActivity(string name, string description, int duration): base(name, description, duration)
    {
        CompilePrompts();
    }
    private void CompilePrompts()
    {
        Console.ForegroundColor = ConsoleColor.White;
        _promptsHEre.Add("Who are your loved ones in your family?? ");
        _promptsHEre.Add("Who have you helped the most this day??");
        _promptsHEre.Add("Who have you helped the most this day? ");
        _promptsHEre.Add("When have you felt the Holy Ghost this month? ");
        _promptsHEre.Add("Who are your role models in your family??");
    }
    private void GetPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(0,_promptsHEre.Count);
        _prompt= _promptsHEre[number];
    }
    private void DisplayPrompt()
    {
        System.Console.WriteLine(_prompt);
    }
    private void DisplayCount()
    {
        System.Console.WriteLine($"You answered  {_responsesNew.Count} times.");
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationTime);
        DateTime currentTime = DateTime.Now;
        GetPrompt();
        while(currentTime < endTime)
        {
            Console.Clear();
            DisplayPrompt();
            string respone = Console.ReadLine();
            _responsesNew.Add(respone);
            currentTime = DateTime.Now;
        }
        DisplayCount();
        DisplayEndingMessage();
    }
}