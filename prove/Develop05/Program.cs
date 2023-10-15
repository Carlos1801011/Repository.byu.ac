
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Variables V
        int userP = 0; 
        int optionMenu = 0;
        bool cSimpleGoal = false;
        List<Goal> listOfGoalsNew = new List<Goal>(); 


        while (optionMenu != 6)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Display the menu
            Console.WriteLine();
            Console.WriteLine($"You have {userP} points.");
            Console.WriteLine();
            Console.WriteLine("[1] Create a New Goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record Event");
            Console.WriteLine("[6] Quit");
            Console.Write("Select a choice from the menu: ");
            optionMenu = int.Parse(Console.ReadLine());


            switch (optionMenu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("[1] Simple Goal");
                    Console.WriteLine("[2] Eternal Goal ");
                    Console.WriteLine("[3] Checklist Goal ");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    switch (goalOption)
                    {
                        //[1] Simple Goal
                        case 1:
                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int simpleGoalPoints = int.Parse(Console.ReadLine());
                            bool finished = false;
                            SimpleGoal simpleGoal = new(simpleGoalName, simpleGoalDescription, simpleGoalPoints, finished);
                            listOfGoalsNew.Add(simpleGoal);
                            break;
                        //[2] Eternal Goal
                        case 2:
                            Console.Clear();

                            Console.Write("What is the name of your goal? ");
                            string eternalGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string eternalGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int eternalGoalPoints = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new(eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                            listOfGoalsNew.Add(eternalGoal);
                            break;
                        //[3] Checklist Goal 
                        case 3:

                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string checklistGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string checklistGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int checklistGoalPoints = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int checklistVerificationCounter = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplish at that many times? ");
                            int checklistBonusGoalCompleted = int.Parse(Console.ReadLine());                         
                            int checkListCounter = 0;
                            CheckListGoal checklistGoal = new(checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistVerificationCounter, checklistBonusGoalCompleted, checkListCounter);
                            listOfGoalsNew.Add(checklistGoal);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong. Please choose another option Please and try again.");
                            break;
                    }
                    break;
                //"[2] List Goal"
                case 2:
                    Console.Clear();
                    Console.WriteLine("The goals are: ");
                    Console.WriteLine();
    
                    int count = 1; 
                    foreach (var goal in listOfGoalsNew)
                    {
                        Console.WriteLine(count + ". " + goal.GetGoalInformation());
                        count++;
                    }
                    break;

                //"[3] Save Goals"  
                case 3:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? Example Mygoal.txt > ");
                    string fileName1 = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName1))
                    {
                        outputFile.WriteLine(userP);

                        foreach (var goal in listOfGoalsNew)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;

                // "[4] Load Goals" 
                case 4:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? ex. Mygoal.txt >  ");
                    fileName1 = Console.ReadLine();
 
                    string[] linesInFile = System.IO.File.ReadAllLines(fileName1);
                    string firstLine = linesInFile[0];
                    userP = int.Parse(firstLine);

                    List<Goal> tempList = new List<Goal>();
                    for (int i = 0; i < linesInFile.Length; i++)
                    {
                        if (i != 0)
                        {
            
                            var parts = linesInFile[i].Split(':')[1].Split(',');
                            if (linesInFile[i].StartsWith("SimpleGoal:"))
                            {
                                SimpleGoal simpleGoal = new(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                                tempList.Add(simpleGoal);
  
                                if (!tempList.Any(goal => goal.GetGoalName() == simpleGoal.GetGoalName()))
                                {
                                    tempList.Add(simpleGoal);
                                }

                            }

                            else if (linesInFile[i].StartsWith("EternalGoal:"))
                            {
                                EternalGoal eternalGoal = new(parts[0], parts[1], int.Parse(parts[2]));

                                if (!tempList.Any(goal => goal.GetGoalName() == eternalGoal.GetGoalName()))
                                {
                                    tempList.Add(eternalGoal);
                                }
                            }
                
                            else if (linesInFile[i].StartsWith("CheckListGoal:"))
                            {
                                CheckListGoal checkListGoal = new(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                                tempList.Add(checkListGoal);
                    
                                if (!tempList.Any(goal => goal.GetGoalName() == checkListGoal.GetGoalName()))
                                {
                                    tempList.Add(checkListGoal);
                                }
                            }
                        }

                    }
                    listOfGoalsNew = tempList;
                    break;

                //"[5] Record Event" 
                case 5:
                    Console.Clear();
                    Console.Write("Which is the goal you accomplish? ");
                    int numberToDelete = int.Parse(Console.ReadLine());
                    int ToDelete = numberToDelete - 1;
                    if (ToDelete >= 0 && ToDelete < listOfGoalsNew.Count)
                    {
                    
                        Goal goalToDelete = listOfGoalsNew[ToDelete];

                        if (goalToDelete is SimpleGoal)
                        {
                            
                            userP = ((SimpleGoal)goalToDelete).GetGoalCompleted(userP);
                            if (cSimpleGoal == false)
                            {
                                Console.WriteLine($"Congratulations! You have earned, {goalToDelete.GetGoalPoints()} points! You are the best");
                                Console.WriteLine($"You now have {userP} points.");
                                cSimpleGoal = true;
                            }

                        }

                        if (goalToDelete is EternalGoal)
                        {
                            userP = ((EternalGoal)goalToDelete).GetGoalCompleted(userP);
                            Console.WriteLine($"Congratulations! You have earned,{goalToDelete.GetGoalPoints()} points! You are the best ");

                        }

                        if (goalToDelete is CheckListGoal)
                        {
                            userP = ((CheckListGoal)goalToDelete).GetGoalCompleted(userP);
                            if (!goalToDelete.GetGoalInformation().StartsWith("[X]"))
                            {
 
                                Console.WriteLine($"Congratulations! You have earned,{goalToDelete.GetGoalPoints()} points! You are the best");
                                Console.WriteLine($"You now have {userP} points Awesome. ");
                            }
                            else
                            {

                            }

                        }

                        listOfGoalsNew.RemoveAt(ToDelete);
                        listOfGoalsNew.Insert(ToDelete, goalToDelete);

                        Console.WriteLine();
                    }
                    break;
                // "[6] Quit"  
                case 6:
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please choose another option.");
                    break;
            }

        }
    }
}