class LectureEvent : Event
{
    private string _Teacher;
    private int _Slots;
    public LectureEvent(string Teacher1, int capacity1, string title, string desc, string date, string time, Address AdressInLecture): base(title,desc,date,time,AdressInLecture,"Lecture Event")
    {
        _Teacher = Teacher1;
        _Slots = capacity1;
    }
    public void FullMessage()
    {
        System.Console.WriteLine(GetTitle());
        System.Console.WriteLine(GetDescription());
        System.Console.WriteLine(GetDate() + " " + GetTime());
        System.Console.WriteLine(GetAddress().FullAddress());
        System.Console.WriteLine("Teacher: "+_Teacher);
        System.Console.WriteLine("Spaces in the meeting: "+_Slots);
    }
}