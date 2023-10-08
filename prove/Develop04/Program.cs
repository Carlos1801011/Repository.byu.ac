using System;

class Program
{
    static void Main(string[] args)
    {
        int input=0;
        while(input != 5)
        {
            // The Menu of the program
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("<<<Welcome to the Mindfulness Program>>>\nPlease choose which activity you would like to do: ");
            System.Console.WriteLine("1) Breathing Activity");
            System.Console.WriteLine("2) Listing Activity");
            System.Console.WriteLine("3) Reflection Activity");
            System.Console.WriteLine("4) Body stretch");
            System.Console.WriteLine("5) Quit");
            input = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (input)

            {
                // The options of the menu
                case 1:
                    BreathingActivity breathAct = new BreathingActivity();
                    breathAct.RunActivity();
                    break;
                case 2:
                    ListingActivity listAct = new ListingActivity();
                    listAct.RunActivity();
                    break;
                case 3:
                    ReflectionActivity refAct = new ReflectionActivity();
                    refAct.RunActivity();
                    break;
                case 4:
                    BodyStretchActivity bodStrec = new BodyStretchActivity();
                    bodStrec.RunActivity();
                    break;
                case 5:
                    System.Console.WriteLine("See you Come back soon! :)))");
                    break;
            }
        }
        
    }
}