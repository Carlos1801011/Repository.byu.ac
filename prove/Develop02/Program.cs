using  System;
using System.IO;

using System.Collections.Generic;
using System.Runtime.Serialization;
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        
        Console.Write("**--------------------------** Welcome to Your Journal App **--------------------------** \n Enter Your Name Please: > ");
        string userN = Console.ReadLine();

        Journal myjournal1 = new Journal();

        myjournal1._names = char.ToUpper(userN[0]) + userN.Substring(1);
        
        List<string> localList = new List<string>();
        bool exitoutProgram = false;
        while(!exitoutProgram){
            List<string> Nlist = new List<string>()
            {
            "Who was the most interesting person I interacted with today?",
            "Did you do your exercises today and how did you feel?",
            "If I had one thing I could do over today, what would it be?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What was the best part of my day?",
            "How did you feel today?",
            "Did you do something today that made you angry? And how did you fix it?",
            };
            Console.WriteLine("Please Select the choise (Ex. 1 to 5) and click Enter ");
            Console.WriteLine("[1] Write your ideas");
            Console.WriteLine("[2] Show the Display");
            Console.WriteLine("[3] Load your ideas");
            Console.WriteLine("[4] Save your ideas");
            Console.WriteLine("[5] Quit");
            string charFile = "No";
            string answFileToload;
            string oChoose = Console.ReadLine();

            switch(oChoose)
            {
            case "1":
                Random random = new Random();
                int num = random.Next(1,6);
                Entry entry11 = new Entry();
                entry11._message = Nlist[num];
                Console.WriteLine(entry11._message);
                Console.Write("Enter your Response Please: > ");
                string userEResponse = Console.ReadLine();
                entry11._response = char.ToUpper(userEResponse[0]) + userEResponse.Substring(1);
                myjournal1._Newentries.Add(entry11);

                break;
            
            case "2":
            if(charFile == "Yes"){
                foreach(string item in localList)
                {
                    Console.WriteLine(item);
                }

            myjournal1.Display();
            Console.WriteLine("To save the current list, please select the number [4]");
            }
            else if(charFile == "No"){
            Console.WriteLine("**-----------------------------------------**");
            myjournal1.Display();
            Console.WriteLine("**-----------------------------------------**");
            Console.WriteLine("To save the current list, please select the number [4] ");
            };
            break;
            case "3":
                charFile = "No";
                Console.WriteLine("What is the file's name? (Ex. myfile.txt)");
                answFileToload = Console.ReadLine();
                string FileNameofpc = answFileToload;

                string[] lines = System.IO.File.ReadAllLines(FileNameofpc);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                    localList.Add(line);
                }
                Console.WriteLine("Filed Loaded In Your PC.");
                charFile = "Yes";
                break;
            case "4":
                Console.WriteLine("What's the file's Name? (Example. myfile.txt)");
                string answFileTosave = Console.ReadLine();

                using(StreamWriter outputfileTXT = new StreamWriter(answFileTosave))
                {
                    outputfileTXT.WriteLine("**----------------------------------**");
                    outputfileTXT.WriteLine($"Name: {myjournal1._names}");

                    foreach(Entry entry in myjournal1._Newentries)
                    {
                        outputfileTXT.WriteLine($"Date:{DateTime.Now.ToString("dd-MM-yyyy")} - prompt: "+entry._message);
                        outputfileTXT.WriteLine($"{entry._response}");
                    }

                    outputfileTXT.WriteLine("**----------------------------------**");
                };
                break;
            case "5":
                exitoutProgram = true;
                break;

                default:
                Console.WriteLine("Wrong. Please choose another option and start again");
                    break;

                }
            }

        }

    }