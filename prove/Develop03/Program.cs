using System;

    public class Program
    {
        static void Main()
        {
            bool quit = false;


            Scripture scripture = new Scripture();


            Reference reference = new Reference();


            Word words = new Word();
            // Select a new verse of scripture
            scripture.SelectaNewScripture();

            reference.TakeReference(scripture.GetNewScripture());
            // Store the hidden verse
            words.StoreHiddenScripture(scripture.GetNewScripture());

            Console.WriteLine($"{scripture.GetNewScripture()}\n");

            do
            {
                // Change console color
                Console.ForegroundColor = ConsoleColor.Blue;
                // Prompt the user to press enter to hide the verse,
                // type 'quit' to end everything or type 'show' to show the verse
                Console.WriteLine("Please Press enter to continue to hide the scripture, type 'quit' to finish all, or type 'show' to show the scripture again:");
                string input = Console.ReadLine();

                if (input == "")
                {
                    Console.Clear();
                    // Hide the words
                    words.HideWords();
                    Console.WriteLine($"{reference.GetadiferentReference()}");


                    Console.WriteLine($"{words.GetoccultScripture()}\n");
                } else if (input == "quit")
                {
                    Console.Clear();
                    quit = true;
                } else if (input == "show")
                {
                    Console.WriteLine($"\n{scripture.GetNewScripture()}\n");
                } else
                // If you don't write anything that works, show this code
                {
                    Console.WriteLine("Invalid Entry Look your caps, and try again");
                }
            } while (!quit);
        }
    }
