using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage right now> > ");
        string response = Console.ReadLine();
        int percenta = int.Parse(response);

        string grade = "";

        if (percenta >= 90)
        {
            grade = "A";
        }
        else if (percenta >= 80)
        {
            grade = "B";
        }
        else if (percenta >= 70)
        {
            grade = "C";
        }
        else if (percenta >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your Grade in this moment is : {grade}");

        if (percenta >= 70)
        {
            Console.WriteLine("You passed :))");   
        }
        else
        {
            Console.WriteLine("Do it better another time but don't give up. :)");
        }
    }
}