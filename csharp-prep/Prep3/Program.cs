using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain1 = true;

        while(playAgain1)
        {
        Random randomG = new Random();
        int Mnumber = randomG.Next(1,2);
        int Suppose = -1;

        while (Suppose != Mnumber)
        {
            Console.Write("What is your Suppose Number? > ");
            Suppose = int.Parse(Console.ReadLine());

            if ( Mnumber >= Suppose)
            {
                Console.WriteLine("Very Higher");
            }
            else if (Mnumber < Suppose)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Got it!");
            }
        }
        Console.Write("Do you want to play again? (yes or no) :) > ");
        string playAgainIn = Console.ReadLine();

        if (playAgainIn.ToLower() != "yes")
        {
            playAgain1 = false;
            
        }
        Console.WriteLine("Thanks you for playing The Magic Number :)");
    }
}
}