class ReceptionEvent : Event
{
    private string _Replyemail;
    public ReceptionEvent(string email, string title, string desc, string date, string time, Address AdressInLecture): base(title,desc,date,time,AdressInLecture,"Reception Event")
    {
        _Replyemail = email;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("Please reply to the email: "+_Replyemail);
    }
    
}