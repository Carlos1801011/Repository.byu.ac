public class ReflectionActivity: Activity
{
    private List<string> _prompt = new List<string>();
    private List<string> _questionsMind = new List<string>();
    public ReflectionActivity(string name, string description, int duration): base(name, description, duration)
    {
        CompileQuestions();
        CompilePrompts();
    }
    public ReflectionActivity():base("Reflection", "This activity will help you recognize and reflect on your life and moments of strength..", 60)
    {
        CompileQuestions();
        CompilePrompts();
    }
    public ReflectionActivity(int duration): base("Reflection", "This activity will help you think about moments in your life and help you recognize the power you have..", duration)
    {
        CompileQuestions();
        CompilePrompts();
    }
    private void CompileQuestions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        _questionsMind.Add("Why was this experience meaningful to you?");
        _questionsMind.Add("Have you ever done anything like this before?");
        _questionsMind.Add("How did you get started?");
        _questionsMind.Add("What made this time different than other times when you were not as successful?");
        _questionsMind.Add("What is your favorite thing about this experience actually?");
        _questionsMind.Add("What could you learn from this experience that applies to other situations?");
        _questionsMind.Add("How can you keep this experience in mind in the future? And how would you put it into practice?");
        _questionsMind.Add("Would you want to do this again? ");
    }
    private void CompilePrompts()
    {
        _prompt.Add("Think of a time when you stood up for someone else.");
        _prompt.Add("Think of a time when you did something really difficult.");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something truly selfless.");
    }
    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0,_prompt.Count());
        string prompt = _prompt[index];
        _prompt.Remove(prompt);
        return prompt;
    }
    public void DisplayPrompt()
    {
        string prompt = GetPrompt();
        System.Console.WriteLine(prompt);
    }
    private string GetQuestion()
    {
        Random rand = new Random();
        int number = rand.Next(0,_questionsMind.Count());
        string question = _questionsMind[number];
        _questionsMind.Remove(question);
        return question;
    }
    public void DisplayQuestion()
    {
        string question = GetQuestion();
        System.Console.WriteLine(question);
    }
    public void RunActivity()
    {
        DisplayBeginningMessage();
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_durationTime);
        Console.Clear();
        DisplayPrompt();
        PauseWithSpinner(5);
        while (currentTime < futureTime)
        {
         DisplayQuestion();
         PauseWithSpinner(3);
         currentTime = DateTime.Now;
         if (_questionsMind.Count() == 0)
         {
            CompileQuestions();
            if (_prompt.Count() == 0)
            {
                CompilePrompts();
            }
            Console.Clear();
            DisplayPrompt();
            PauseWithSpinner(5);
         }
        }
        Console.Clear();
        DisplayEndingMessage();
    }
}