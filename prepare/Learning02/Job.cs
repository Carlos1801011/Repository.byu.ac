using System;

public class Job{

    public string _jobtitle;
    public string _company;

    public int _endYear;

    public int _startYear;


    public void display()
    {
        Console.WriteLine($"{_jobtitle} ({_company}) {_startYear}-{_endYear}");
    }
}