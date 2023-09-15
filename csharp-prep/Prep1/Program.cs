using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? > ");
        string firstline = Console.ReadLine();

        Console.Write("What is your last name? > ");
        string secondline = Console.ReadLine();

        Console.WriteLine($"Your name is {secondline}, {firstline} {secondline}.");
    
    }
}