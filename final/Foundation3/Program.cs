using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Address AdressInLecture = new Address("Doctor 12 Rachel", "Vegas,Nevada", "ID", "USA");
        
        
        LectureEvent lectureEvent = new LectureEvent("Teacher Sonia",25,"Class","Career Development", "Agost 15","6:00 PM",AdressInLecture);
        System.Console.WriteLine("Class Event");
        System.Console.WriteLine("Full Message:");
        lectureEvent.FullMessage();
        System.Console.WriteLine("\nStandard Message:");
        lectureEvent.StandardMessage();
        System.Console.WriteLine("\n Short Message: ");
        lectureEvent.ShortMessage();
        

        
        ReceptionEvent receptionEvent = new ReceptionEvent("ReceptionHotel@email.com","Hotel Reception","Holiday Inn Hotel","December 10","08:00 AM",AdressInLecture);
        System.Console.WriteLine();
        System.Console.WriteLine("Reception Event");
        System.Console.WriteLine("Full Message");
        receptionEvent.FullMessage();
        System.Console.WriteLine("\nStandard Message");
        receptionEvent.StandardMessage();
        System.Console.WriteLine("\nShort Message");
        receptionEvent.ShortMessage();
        

        
        OutdoorEvent outdoorEvent = new OutdoorEvent("Rainy","Basketball Game","Falcons vs Headers","Oct 16","8:30 PM", AdressInLecture);
        System.Console.WriteLine();
        System.Console.WriteLine("Outdoor Event");
        System.Console.WriteLine("Full Message");
        outdoorEvent.FullMessage();
        System.Console.WriteLine("\nStandard Message");
        outdoorEvent.StandardMessage();
        System.Console.WriteLine("\nShort Message");
        outdoorEvent.ShortMessage();
        
    }
}