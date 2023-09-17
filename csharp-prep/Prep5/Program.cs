using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string user = PromptUserName();
        int userN = PromptUserNumber();



        int squaredN = SquareNumber(userN);
        
        DisplayResult(user, squaredN);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program to funtions! :)");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name Please : > ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite positive number: > ");
        int FavN = int.Parse(Console.ReadLine());

        return FavN;
    }

    static int SquareNumber(int FavN)
    {
        int square = FavN * FavN;
        return square;
    }
    static void DisplayResult(string YourName, int square)
    {
        Console.WriteLine($"{YourName}, the square of your favorite number is {square}");
    }
}